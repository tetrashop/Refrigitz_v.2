//----------------------------------------------------------------------------------------
//	Copyright © 2006 - 2014 Tangible Software Solutions Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class provides the ability to initialize array elements with the default
//	constructions for the array type.
//----------------------------------------------------------------------------------------
internal static class Arrays
{
	internal static T[] InitializeWithDefaultInstances<T>(int length) where T : new()
	{
		T[] array = new T[length];
		for (int i = 0; i < length; i++)
		{
			array[i] = new T();
		}
		return array;
	}
}