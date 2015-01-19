using NUnit.Framework;
using System;

namespace EnumExtensions.Tests
{
	public enum TestEnum
	{
		[StringValue("From Attribute")]
		FromAttribute = 1,
		[StringValue("Test", "EnumExtensions.Tests.Resources")]
		FromResource = 2,
		BuiltInToString = 3
	}

	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void GetValueFromAttribute ()
		{
			var testEnum = TestEnum.FromAttribute;
			Assert.AreEqual ("From Attribute", testEnum.GetStringValue ());
		}
		[Test ()]
		public void GetValueFromResourceFile ()
		{

			var testEnum = TestEnum.FromResource;
			Assert.AreEqual ("From Resource File", testEnum.GetStringValue ());
		}

		[Test ()]
		public void GetValueFromBuiltInToString ()
		{
			var testEnum = TestEnum.BuiltInToString;
			Assert.AreEqual ("BuiltInToString", testEnum.GetStringValue ());
		}
	}
}

