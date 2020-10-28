namespace H3MP.Utils
{
	public static class ArraySerializers
	{
		public static FixedArraySerializer<TValue> ToArrayFixed<TValue>(this ISerializer<TValue> @this, int length)
		{
			return new FixedArraySerializer<TValue>(@this, length);
		}

		public static DynamicArraySerializer<TValue> ToArrayDynamic<TValue>(this ISerializer<TValue> @this, ISerializer<int> length)
		{
			return new DynamicArraySerializer<TValue>(@this, length);
		}
	}
}