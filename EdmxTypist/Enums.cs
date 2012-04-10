namespace EdmxTypist
{
	public enum NameContextEnum
	{
		AssociationRole,
		ComplexProperty,
		ComplexType,
		EntitySet,
		EntityType,
		Method,
		NavigationProperty,
		ScalarProperty,
		Container
	}

	public enum MultiplicityEnum
	{
		One,
		Many,
		ZeroOrOne
	}

	internal enum VisibilityEnum
	{
		Internal,
		Private,
		Protected,
		Public
	}
}