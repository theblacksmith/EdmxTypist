using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdmxTypist
{
	using System.IO;
	using System.Xml;
	using System.Xml.Linq;
	using Model;

	/// <summary>
	/// Represents an .edmx file and has a lot of useful methods are used across the app.
	/// </summary>
	public class EdmxFile
	{
		public XDocument XDoc { get; private set; }

		public XElement Storage { get; private set; }
		public XElement Concept { get; private set; }
		public XElement Mapping { get; private set; }
		public XElement Diagram { get; private set; }

		/// <summary>
		/// The Namespace for Storage Schema
		/// </summary>
		public const string SSDL_NS = "http://schemas.microsoft.com/ado/2009/02/edm/ssdl";

		/// <summary>
		/// The Namespace for Conceptual Schema
		/// </summary>
		public const string CSDL_NS = "http://schemas.microsoft.com/ado/2008/09/edm";

		/// <summary>
		/// The Namespace for C-S Mapping
		/// </summary>
		public const string MSL_NS = "http://schemas.microsoft.com/ado/2008/09/mapping/cs";

		/// <summary>
		/// The Namespace for the Diagram tags
		/// </summary>
		public const string Diagram_NS = "http://schemas.microsoft.com/ado/2008/10/edmx";

		public EdmxFile(String source)
		{
			XDoc = XDocument.Load(source);

			if (XDoc.Root == null)
				throw new Exception("Couldn't load the edmx file");

			Storage = XDoc.Descendants(XName.Get("Schema", SSDL_NS)).First();
			Concept = XDoc.Descendants(XName.Get("Schema", CSDL_NS)).First();
			Mapping = XDoc.Descendants(XName.Get("Mapping", MSL_NS)).First();
			Diagram = XDoc.Descendants(XName.Get("Diagram", Diagram_NS)).First();
		}

		public void Save(string outputFile)
		{
			/*
			var xws = new XmlWriterSettings();
			xws.NamespaceHandling = NamespaceHandling.Default;
			xws.Indent = true;

			using (var stream = File.Create(outputFile))
			using (XmlWriter xw = XmlWriter.Create(stream, xws))
				XDoc.Save(xw);
			 */
			XDoc.Save(outputFile);
		}
	}
}
