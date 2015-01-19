using System;

namespace EnumExtensions
{
	public class StringValueAttribute : Attribute
	{
		public string StringValue { get; protected set; }
		public string ResourceName { get; protected set; }
		public string ResourceNamespace { get; protected set; }

		public StringValueAttribute(string stringValue)
		{
			StringValue = stringValue;
		}
		public StringValueAttribute(string resourceName, string resourceNamespace)
		{
			ResourceName = resourceName;
			ResourceNamespace = resourceNamespace;
		}
	}
}

