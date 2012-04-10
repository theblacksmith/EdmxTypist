namespace EdmxTypist.ModelInfo
{
	using System.Collections.Generic;

	/// <remarks>
	/// Represents a sample of the names found in a file
	/// </remarks>
	public class EdmxNamesSample
	{
		public List<string> EntitySets = new List<string>();
		public List<string> EntityTypes = new List<string>();
		public List<string> NavigationProperties = new List<string>();
		public List<string> Scalars = new List<string>();
		public List<string> Methods = new List<string>();
		public List<string> ComplexTypes = new List<string>();
		public List<string> ComplexProperties = new List<string>();
		public List<string> Associations = new List<string>();
	}
}