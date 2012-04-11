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
namespace EdmxTypist
{
	using System;
	using System.Linq;
	using System.Xml.Linq;

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
