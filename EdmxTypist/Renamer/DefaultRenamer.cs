/**
 * This file is part of Edmx Typist  - A cyber typist to help you fix your edmx file.
 * Copyright (C) 2012 Saulo Vallory <me@saulovallory.com>
 * 
 * Edmx Typist is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *  
 * Edmx Typist is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with Edmx Typist. If not, see <http://www.gnu.org/licenses/>.
 */
namespace EdmxTypist.Renamer
{
	using System;
	using System.Text.RegularExpressions;
	using Flexer;
	using Model;
	using Options;

	public class DefaultRenamer : IRenamer
	{
		protected readonly Flexer Inflector;
		protected GlobalOptions Options;

		public DefaultRenamer(RuleSet ruleSet, GlobalOptions opts)
		{
			Inflector = new Flexer(ruleSet);
			Options = opts;
		}

		public string BeforeRenaming(RenameableObject renamable, out bool skipRules)
		{
			skipRules = false;
			return renamable.Name;
		}

		public string AfterRenaming(RenameableObject renamable, string newName)
		{
			return newName;
		}

		/// <summary>
		/// ToPlural is called whenever a word (entity set/type, or member) needs to be pluralized.
		/// </summary>
		/// <param name="nameContext">Name context, describes the type of object being named.</param>
		/// <param name="word">The word to pluralize.</param>
		/// <param name="suggestion">Suggested pluralization of {word}.</param>
		/// <param name="text">Entire entity set/type, or member name.</param>
		/// <param name="parentName">Name of the parent object (if any).</param>
		/// <returns>Pluralization of the word parameter.</returns>
		public string ToPlural(NameContextEnum nameContext, string word, string suggestion, string text, string parentName)
		{
			if (Options.ForContext(nameContext).CaseStyle == CaseStyleEnum.CamelCase)
				return Inflector.Camelize(word);

			return word;
		}

		/// <summary>
		/// ToSingular is called whenever a word (entity set/type, or member) needs to be singularized.
		/// </summary>
		/// <param name="nameContext">Name context, describes the type of object being named.</param>
		/// <param name="word">The word to singularize.</param>
		/// <param name="suggestion">Suggested singularization of {word}.</param>
		/// <param name="text">Entire entity set/type, or member name.</param>
		/// <param name="parentName">Name of the parent object (if any).</param>
		/// <returns>Singularization of the word parameter.</returns>
		public string ToSingular(NameContextEnum nameContext, string word, string suggestion, string text, string parentName)
		{
			if (Options.ForContext(nameContext).CaseStyle == CaseStyleEnum.CamelCase)
				return Inflector.Camelize(word);

			return word;
		}

		public bool HasSettingsDialog()
		{
			return false;
		}

		public void ShowSettingsDialog()
		{
			throw new NotImplementedException();
		}

		public string Format(NameContextEnum nameContext, string word, string suggestion, string text, string parentName)
		{
			if (Options.ForContext(nameContext).CaseStyle == CaseStyleEnum.CamelCase)
				word = Inflector.Camelize(word);

			return word;
		}

		public string GetName(RenameableObject renamable, string text)
		{
			var opt = Options.Defaults;

			if (renamable.Renamed)
				return text.Prefix().Dot(renamable.Name);

			bool skipRules = false;
			string prefix = text.Prefix();

			var name = BeforeRenaming(renamable, out skipRules);

			if (!skipRules)
			{
				name = Rename(renamable, text);
			}

			name = AfterRenaming(renamable, name);

			renamable.Name = name;

			return prefix.Dot(name);
		}

		/// <summary>
		/// Encapsulated Regex.Replace because maybe we'll do fancy stuff around it later
		/// </summary>
		private string ApplyRegex(string name, string match, string replace)
		{
			return Regex.Replace(name, match, replace);
		}

		public string Rename(RenameableObject obj, string text)
		{
			var options = Options.ForContext(obj.GetNameContext());
			var name = obj.Name;

			if (options.ApplyRegex == ApplyRegexEnum.InsteadOfRules)
				return ApplyRegex(name, options.RegexMatch, options.RegexReplace);


			if (options.ApplyRegex == ApplyRegexEnum.BeforeRules)
				name = ApplyRegex(name, options.RegexMatch, options.RegexReplace);

			if (!String.IsNullOrEmpty(options.RemovePrefixes))
			{
				foreach (var prefix in options.ListRemovePrefixes())
				{
					if (name.ToLower().StartsWith(prefix.ToLower()))
					{
						name = name.Remove(0, prefix.Length);
					}
				}
			}

			if (!String.IsNullOrEmpty(options.RemoveSuffixes))
			{
				foreach (var suffix in options.ListRemoveSuffixes())
				{
					if (name.ToLower().EndsWith(suffix.ToLower()))
					{
						name = name.Remove(name.Length - suffix.Length);
					}
				}
			}

			if (!String.IsNullOrEmpty(options.AddPrefix))
				name = options.AddPrefix + name;

			if (!String.IsNullOrEmpty(options.AddSuffix))
				name = options.AddSuffix + name;

			switch (options.Flexing)
			{
				case FlexingStrategyEnum.Pluralize:
					name = name + "s";
					break;
			}

			switch (options.CaseStyle)
			{
				case CaseStyleEnum.CamelCase:
					name = Inflector.Camelize(name);
					break;
				case CaseStyleEnum.Undescores:
					name = Inflector.Underscore(name);
					break;
				case CaseStyleEnum.LowerCamelCase:
					name = Inflector.Pascalize(name);
					break;
			}

			var prop = obj as MetaScalarProperty;

			if (prop != null && prop.isKey && options.RemoveEntityNameFromKey)
			{
				if (name.ToLower().StartsWith(prop.EntityType.Name.ToLower()))
					name = name.Remove(0, prop.EntityType.Name.Length).TrimStart('_');

			}

			if (options.ApplyRegex == ApplyRegexEnum.AfterRules)
				name = ApplyRegex(name, options.RegexMatch, options.RegexReplace);

			return name;
		}

		public string Rename(MetaAssociationRole role)
		{
			return role.Name;
		}

		public string Rename(MetaEntitySet entitySet)
		{
			return entitySet.Name;
		}

		public string Rename(MetaEntityType entityType)
		{
			return entityType.Name;
		}

		public string Rename(MetaMethod method)
		{
			return method.Name;
		}

		public string Rename(MetaScalarProperty property)
		{
			return property.Name;
		}

		public string Rename(MetaNavigationProperty navProp)
		{
			return navProp.Name;
		}

		public string Rename(MetaComplexType complexType)
		{
			return complexType.Name;
		}

		public string Rename(MetaComplexProperty complexProp)
		{
			return complexProp.Name;
		}
	}
}
