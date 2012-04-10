namespace EdmxTypist.Options
{
	using System;
	using System.ComponentModel;

	public enum FlexingStrategyEnum
	{
		BeSmart,
		Pluralize,
		Singularize,
		LeaveItAlone
	}

	public enum CaseStyleEnum
	{
		CamelCase,
		LowerCamelCase,
		Undescores
	}

	public enum ApplyRegexEnum
	{
		[Description("Don't apply")]
		DontApply,

		[Description("Instead of rules")]
		InsteadOfRules,

		[Description("Before rules")]
		BeforeRules,

		[Description("After rules")]
		AfterRules
	}
}
