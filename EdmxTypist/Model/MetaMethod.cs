namespace EdmxTypist.Model
{
	public partial class MetaMethod : RenameableObject
	{
		public override NameContextEnum GetNameContext()
		{
			return NameContextEnum.Method;
		}
	}
}
