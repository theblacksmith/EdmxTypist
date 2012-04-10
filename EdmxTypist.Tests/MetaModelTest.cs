using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdmxTypist.Model;

namespace EdmxTool.Tests
{
	using EdmxTypist;

	[TestClass]
	public class MetaModelTest
	{
		[TestMethod]
		public void TestMetaModelLoad()
		{
			var edmx = new EdmxFile(@"Movies.edmx");
			var model = new MetaModel(edmx);
		}
	}
}
