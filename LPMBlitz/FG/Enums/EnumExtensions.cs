﻿using System.ComponentModel;

namespace LPMBlitz.FG.Enums;

public static class EnumExtensions
{
	public static string GetDescription(this Enum value)
	{
		var type = value.GetType();
		var name = Enum.GetName(type, value);
		if (name == null) return null;
		
		var field = type.GetField(name);
		if (field == null) return null;
		
		var attr = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
		return attr?.Description;
	}
}