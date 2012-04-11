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
	using Model;

	public interface IRenamer
	{
		string BeforeRenaming(RenameableObject renamable, out bool skipRules);
		string AfterRenaming(RenameableObject renamable, string newName);

		/// <summary>
		/// ToPlural is called whenever a word (entity set/type, or member) needs to be pluralized.
		/// </summary>
		/// <param name="nameContext">Name context, describes the type of object being named.</param>
		/// <param name="word">The word to pluralize.</param>
		/// <param name="suggestion">Suggested pluralization of {word}.</param>
		/// <param name="text">Entire entity set/type, or member name.</param>
		/// <param name="parentName">Name of the parent object (if any).</param>
		/// <returns>Pluralization of the word parameter.</returns>
		string ToPlural(NameContextEnum nameContext, string word, string suggestion, string text, string parentName);

		/// <summary>
		/// ToSingular is called whenever a word (entity set/type, or member) needs to be singularized.
		/// </summary>
		/// <param name="nameContext">Name context, describes the type of object being named.</param>
		/// <param name="word">The word to singularize.</param>
		/// <param name="suggestion">Suggested singularization of {word}.</param>
		/// <param name="text">Entire entity set/type, or member name.</param>
		/// <param name="parentName">Name of the parent object (if any).</param>
		/// <returns>Singularization of the word parameter.</returns>
		string ToSingular(NameContextEnum nameContext, string word, string suggestion, string text, string parentName);

		bool HasSettingsDialog();
		void ShowSettingsDialog();
		string Format(NameContextEnum nameContext, string word, string suggestion, string text, string parentName);
		string GetName(RenameableObject renamable, string text);
		string Rename(RenameableObject obj, string text);
		string Rename(MetaAssociationRole role);
		string Rename(MetaEntitySet entitySet);
		string Rename(MetaEntityType entityType);
		string Rename(MetaMethod method);
		string Rename(MetaScalarProperty property);
		string Rename(MetaNavigationProperty navProp);
		string Rename(MetaComplexType complexType);
		string Rename(MetaComplexProperty complexProp);
	}
}