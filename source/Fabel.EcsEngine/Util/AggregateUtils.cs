namespace Fabel.EcsEngine.Util
{
	internal static class AggregateUtils
	{
		public static bool AllTrue(bool accumulator, bool value) => accumulator && value;
	}
}
