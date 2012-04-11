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

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

static class XElementExtensions
{
	public static XElement NSElement(this XElement element, string prefix, string name)
	{
		return element.Element(element.GetNamespaceOfPrefix(prefix) + name);
	}

	public static IEnumerable<XElement> NSElements(this XElement element, string prefix, string name)
	{
		return element.Elements(element.GetNamespaceOfPrefix(prefix) + name);
	}

	private static XAttribute FindXAtt(XElement el, string name)
	{
		XNamespace ns = null;

		if (name.Contains(":"))
		{
			var strs = name.Split(':');
			ns = el.GetNamespaceOfPrefix(strs[0]);
			name = strs[1];
		}

		var selector = (ns != null) ?
			XName.Get(name, ns.ToString()) : name;

		return el.Attribute(selector);
	}

	public static string Att(this XElement el, string name)
	{
		var xAttribute = FindXAtt(el, name);

		return xAttribute != null ? xAttribute.Value : null;
	}

	public static void Att(this XElement el, string name, string value)
	{
		var xAttribute = FindXAtt(el, name);

		if (xAttribute != null)
			xAttribute.Value = value;
	}

	public static bool ContainsAttribute(this XElement el, string name)
	{
		var xAttribute = FindXAtt(el, name);

		return xAttribute != null;
	}

	/// <summary>
	/// Find the descendants of a node
	/// </summary>
	/// <param name="el"></param>
	/// <param name="nodeName"></param>
	/// <param name="NS">Optional. The namespace of the descendants</param>
	/// <returns></returns>
	public static IEnumerable<XElement> D(this XElement el, string nodeName, string NS = null)
	{
		return el.Descendants(XName.Get(nodeName, NS ?? el.GetDefaultNamespace().ToString()));
	}

	/// <summary>
	/// Find the first child node which that has the passed <paramref name="nodeName"/>.
	/// </summary>
	/// <param name="el"></param>
	/// <param name="nodeName"></param>
	/// <param name="NS">Optional. The namespace of the descendant</param>
	/// <returns></returns>
	public static XElement E(this XElement el, string nodeName, string NS = null)
	{
		return el.Element(XName.Get(nodeName, NS ?? el.GetDefaultNamespace().ToString()));
	}

	/// <summary>
	/// Find the all the child nodes that has the passed <paramref name="nodeName"/>.
	/// </summary>
	/// <param name="el"></param>
	/// <param name="nodeName"></param>
	/// <param name="NS">Optional. The namespace of the descendant</param>
	/// <returns></returns>
	public static IEnumerable<XElement> Es(this XElement el, string nodeName, string NS = null)
	{
		return el.Elements(XName.Get(nodeName, NS ?? el.GetDefaultNamespace().ToString()));
	}

	public static IEnumerable<XElement> Where(this IEnumerable<XElement> els, string attName, string attValue)
	{
		return els.Where((x, i) => x.Att(attName) == attValue);
	}

	public static XElement FirstWhere(this IEnumerable<XElement> els, string attName, string attValue)
	{
		return els.Where((x, i) => x.Att(attName) == attValue).FirstOrDefault();
	}

	public static XElement WithName(this IEnumerable<XElement> els, string name)
	{
		return els.FirstWhere("Name", name);
	}
}