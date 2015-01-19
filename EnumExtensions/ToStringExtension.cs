using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Collections;

namespace EnumExtensions
{
	public static class ToStringExtension
	{
		public static string GetStringValue(this Enum value)
		{
			var type = value.GetType();

			//var fieldinfo = type.GetField(value.ToString());
			var fieldinfo = type.GetTypeInfo ().GetDeclaredField (value.ToString ());

			var attributes = fieldinfo.GetCustomAttributes(typeof(StringValueAttribute), false) as StringValueAttribute[];


			if (attributes.Any() && !string.IsNullOrEmpty(attributes.First().ResourceName)) 
			{
				try{
					ResourceManager rm = new ResourceManager(attributes[0].ResourceNamespace, type.GetTypeInfo().Assembly);
					return rm.GetString(attributes[0].ResourceName) ?? value.ToString();
				}
				catch(Exception) {
					return value.ToString();
				}
			}
			if (attributes.Any () && !string.IsNullOrWhiteSpace (attributes.First ().StringValue))
				return attributes.First ().StringValue;


			return value.ToString();
		}
	}
}

