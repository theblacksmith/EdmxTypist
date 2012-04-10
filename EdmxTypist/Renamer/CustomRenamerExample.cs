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
