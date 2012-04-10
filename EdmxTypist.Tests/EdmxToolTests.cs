namespace EdmxTool.Tests
{
	using System.IO;
	using EdmxTypist;
	using EdmxTypist.Options;
	using EdmxTypist.Renamer;
	using Flexer.RuleSets;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class EdmxToolTests
	{
		[TestMethod]
		public void Run()
		{
			var tool = new Typist();
			
			tool.Run(@"Movies.edmx", new PortugueseRuleSet(), new GlobalOptions(), null);
		}
	}
}
