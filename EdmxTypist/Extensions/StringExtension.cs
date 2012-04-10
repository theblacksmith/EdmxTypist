using System;
using System.Linq;

public static class StringExtension
{
	/// <summary>
	/// Returns the last part of a string.
	/// </summary>
	/// <param name="str">The string</param>
	/// <param name="splitter">Optional. Defaults to '.'. The separator char.</param>
	/// <returns></returns>
	public static string LastPart(this string str, char splitter = '.')
	{
		return str.Split(splitter).Last();
	}

	/// <summary>
	/// Adds <paramref name="part"/> to the end of the current string with a "." before it.
	/// </summary>
	/// <param name="str">The string</param>
	/// <param name="part">Part to be added</param>
	/// <returns>Concatenated string</returns>
	public static string Dot(this string str, string part)
	{
		if (String.IsNullOrEmpty(str))
			return part;

		if (String.IsNullOrEmpty(part))
			return str;

		return str.TrimEnd('.') + '.' + part;
	}

	/// <summary>
	/// Returns the prefix of the string, i.e. the substring from index 0 to LastIndexOf(<paramref name="splitter"/>)
	/// </summary>
	/// <param name="str">The string</param>
	/// <param name="splitter">Optional. Defaults to '.'. The separator char.</param>
	/// <returns>The substring from index 0 to LastIndexOf(<paramref name="splitter"/>)</returns>
	public static string Prefix(this string str, char splitter = '.')
	{
		var index = str.LastIndexOf('.');

		if (index >= 0)
			return str.Substring(0, index);

		return "";
	}
}