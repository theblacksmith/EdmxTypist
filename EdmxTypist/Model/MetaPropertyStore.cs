using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdmxTypist.Model
{
	public partial class MetaPropertyStore
	{
		/// <summary>
		/// Represents the conceptual object tied to this store, which will be either a <see cref="MetaScalarProperty"/> or a <see cref="MetaComplexTypeProperty"/>.
		/// You can determine the type of the returned object using 
		/// </summary>
		public Object Concept
		{
			get
			{
				if (ScalarProperty != null)
					return ScalarProperty;

				if (ComplexTypeProperty != null)
					return ComplexTypeProperty;

				return null;
			}

			set
			{
				if (value is MetaScalarProperty)
					ScalarProperty = value as MetaScalarProperty;
				else if (value is MetaComplexTypeProperty)
					ComplexTypeProperty = value as MetaComplexTypeProperty;
				else
					throw new Exception("Invalid type. Concept must be either a MetaScalarProperty or a MetaComplexTypeProperty");
			}
		}
	}
}
