namespace EdmxTypist.Renamer
{
	using Model;

	public interface IRenamer
	{
		string BeforeRenaming(RenameableObject renamable, out bool skipRules);
		string AfterRenaming(RenameableObject renamable, string newName);

		/// <summary>
		/// ToPlural is called whenever a word (entity set/type, or member) needs to be pluralized.
		/// </summary>
		/// <param name="nameContext">Name context, describes the type of object being named.</param>
		/// <param name="word">The word to pluralize.</param>
		/// <param name="suggestion">Suggested pluralization of {word}.</param>
		/// <param name="text">Entire entity set/type, or member name.</param>
		/// <param name="parentName">Name of the parent object (if any).</param>
		/// <returns>Pluralization of the word parameter.</returns>
		string ToPlural(NameContextEnum nameContext, string word, string suggestion, string text, string parentName);

		/// <summary>
		/// ToSingular is called whenever a word (entity set/type, or member) needs to be singularized.
		/// </summary>
		/// <param name="nameContext">Name context, describes the type of object being named.</param>
		/// <param name="word">The word to singularize.</param>
		/// <param name="suggestion">Suggested singularization of {word}.</param>
		/// <param name="text">Entire entity set/type, or member name.</param>
		/// <param name="parentName">Name of the parent object (if any).</param>
		/// <returns>Singularization of the word parameter.</returns>
		string ToSingular(NameContextEnum nameContext, string word, string suggestion, string text, string parentName);

		bool HasSettingsDialog();
		void ShowSettingsDialog();
		string Format(NameContextEnum nameContext, string word, string suggestion, string text, string parentName);
		string GetName(RenameableObject renamable, string text);
		string Rename(RenameableObject obj, string text);
		string Rename(MetaAssociationRole role);
		string Rename(MetaEntitySet entitySet);
		string Rename(MetaEntityType entityType);
		string Rename(MetaMethod method);
		string Rename(MetaScalarProperty property);
		string Rename(MetaNavigationProperty navProp);
		string Rename(MetaComplexType complexType);
		string Rename(MetaComplexProperty complexProp);
	}
}