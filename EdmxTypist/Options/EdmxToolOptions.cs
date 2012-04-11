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
namespace EdmxTypist.Options
{
	using System.IO;
	using Model;

	/// <remarks>
	/// Holds global options and <see cref="ContextOptions"/> for each <see cref="NameContextEnum"/>.
	/// </remarks>
	public class GlobalOptions
	{
		/// <summary>
		/// Holds the default options. Useful for applying the same options to many contexts by using <see cref="ContextOptions.CopyFrom"/>.
		/// </summary>
		public ContextOptions Defaults { get; set; }

		/// <summary>
		/// Options for the <see cref="NameContextEnum">naming context</see> <see cref="NameContextEnum.EntitySet"/>
		/// </summary>
		public ContextOptions EntitySets { get; set; }

		/// <summary>
		/// Options for the <see cref="NameContextEnum">naming context</see> <see cref="NameContextEnum.EntityType"/>
		/// </summary>
		public ContextOptions EntityTypes { get; set; }

		/// <summary>
		/// Options for the <see cref="NameContextEnum">naming context</see> <see cref="NameContextEnum.AssociationRole"/>
		/// </summary>
		public ContextOptions Associations { get; set; }

		/// <summary>
		/// Options for the <see cref="NameContextEnum">naming context</see> <see cref="NameContextEnum.ScalarProperty"/>
		/// </summary>
		public ContextOptions ScalarMembers { get; set; }

		/// <summary>
		/// Options for the <see cref="NameContextEnum">naming context</see> <see cref="NameContextEnum.ComplexType"/>
		/// </summary>
		public ContextOptions ComplexTypes { get; set; }

		/// <summary>
		/// Options for the <see cref="NameContextEnum">naming context</see> <see cref="NameContextEnum.ComplexProperty"/>
		/// </summary>
		public ContextOptions ComplexProps { get; set; }

		/// <summary>
		/// Options for the <see cref="NameContextEnum">naming context</see> <see cref="NameContextEnum.Method"/>
		/// </summary>
		public ContextOptions Methods { get; set; }

		/// <summary>
		/// Options for the <see cref="NameContextEnum">naming context</see> <see cref="NameContextEnum.NavigationProperty"/>
		/// </summary>
		public ContextOptions NavigationProps { get; set; }

		public bool ReplaceSourceFileContents { get; set; }

		/// <summary>
		/// A pattern to specify the name of the output file. Default: {name}-fixed.edmx
		/// The pattern may contain the <c>{name}</c> placeholder. In that case, it will be replaced by the name of the original file.
		/// </summary>
		/// <example>
		/// options.OutputFileNamePattern = "fixed-{name}.edmx"
		/// // Input file: MyModel.edmx
		/// // Output file: fixed-MyModel.edmx
		/// </example>
		public string OutputFileNamePattern { get; set; }

		/// <summary>
		/// Instantiates <see cref="ContextOptions"/> and set defaults to global options.
		/// </summary>
		public GlobalOptions()
		{
			EntitySets = new ContextOptions();
			EntityTypes = new ContextOptions();
			NavigationProps = new ContextOptions();
			Associations = new ContextOptions();
			ScalarMembers = new ContextOptions();
			ComplexProps = new ContextOptions();
			ComplexTypes = new ContextOptions();
			Methods = new ContextOptions();

			OutputFileNamePattern = "{name}-fixed.edmx";
		}

		/// <summary>
		/// Returns an <see cref="ContextOptions"/> for the received <see cref="NameContextEnum"/>.
		/// </summary>
		/// <param name="nameContext">The context to get the options for</param>
		/// <returns></returns>
		public ContextOptions ForContext(NameContextEnum nameContext)
		{
			switch(nameContext)
			{
				case NameContextEnum.EntitySet:
					return EntitySets;
				case NameContextEnum.EntityType:
					return EntityTypes;
				case NameContextEnum.NavigationProperty:
					return NavigationProps;
				case NameContextEnum.ScalarProperty:
					return ScalarMembers;
				case NameContextEnum.AssociationRole:
					return Associations;
				case NameContextEnum.Method:
					return NavigationProps;
				case NameContextEnum.ComplexType:
					return ComplexTypes;
				case NameContextEnum.ComplexProperty:
					return ComplexProps;
			}

			return Defaults;
		}

		/// <summary>
		/// Gets the input file path and returns the output file path.
		/// The output of this method is determined by two configuration options: 
		/// <see cref="ReplaceSourceFileContents"/> and <see cref="OutputFileNamePattern"/>.
		/// If <see cref="ReplaceSourceFileContents"/> is <c>true</c> this method returns the value 
		/// of <paramref name="inputFilePath"/>. Otherwise it will use <see cref="OutputFileNamePattern"/>
		/// to generate a new file name (in the same folder though).
		/// </summary>
		/// <param name="inputFilePath"></param>
		/// <returns></returns>
		public string GetOutputPath(string inputFilePath)
		{
			if (ReplaceSourceFileContents)
				return inputFilePath;

			var folder = Path.GetPathRoot(inputFilePath);
			var filename = Path.GetFileNameWithoutExtension(inputFilePath);

			return folder + OutputFileNamePattern.Replace("{name}", filename);
		}
	}
}
