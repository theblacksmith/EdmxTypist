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
	using Flexer;
	using Options;

	class CustomRenamerExample : DefaultRenamer
	{
		public CustomRenamerExample(RuleSet ruleSet, GlobalOptions opts) : base(ruleSet, opts)
		{
		}

		public new string BeforeRenaming(NameContextEnum nameContext, string name, string parentName, out bool skipRules)
		{
			// We just want to rename entities and entity sets
			skipRules = !(nameContext == NameContextEnum.EntityType || nameContext == NameContextEnum.EntitySet);
			return name;
		}

		public new string AfterRenaming(NameContextEnum nameContext, string name, string originalName, string parentName)
		{
			// Let's just log the amazing renaming we just did :)
			Console.WriteLine("{0} -> {1}", originalName, name);
			return name;
		}

		public new string ToPlural(NameContextEnum nameContext, string word, string suggestion, string text, string parentName)
		{
			// overwrite this method if you want to do fancier stuff when pluralizing	
			return suggestion;
		}

		public new string ToSingular(NameContextEnum nameContext, string word, string suggestion, string text, string parentName)
		{
			// same here
			return suggestion;
		}

		public new bool HasSettingsDialog()
		{
			// return true here if you want to provide an additional settings dialog
			return false;
		}

		public new void ShowSettingsDialog()
		{
			// Render your settings dialog here!
			throw new NotImplementedException();
		}
	}
}
