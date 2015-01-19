# Enum Extensions

## History

There were many times where I had to display the string value of an enum instead of numeric value.  Because the built-in ```ToString()``` returns an ugly looking string I prefered not to use it and started to find if there is something better. I ran into some blog post on attribues and their usage.  So I decided to use attributes to specify what I want to show as string representation of an enum.

Later when I ran into a stackoverflow question that needed the same mechanism. One of the commenters made a great point about localization.  So I thought of expanding my code a little bit more and made it a PCL (Portable Class Library), so it can be used in crossplatform .Net situation.

## Thought
The idea was to have an enum value be able to have an attribute called ```StringValue```.  This attribute should work in a way that one should be able to either specify a literal text to display or should be able to give a reference to a data value pair in a resource file.  So the attribute should have two constructors, where one takes just the string, the other takes a key name and namespace for a resource file entry.

## Usage

Declaring the Enum
```csharp
	public enum TestEnum
	{
		[StringValue("From Attribute")]
		FromAttribute = 1,
		[StringValue("Test", "EnumExtensions.Tests.Resources")]
		FromResource = 2,
		BuiltInToString = 3
	}
```
When you need to show the string value.
```csharp	
	//Get the string value...
	TestEnum.FromResource.GetStringValue();
	
```
