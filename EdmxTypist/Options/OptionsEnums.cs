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
