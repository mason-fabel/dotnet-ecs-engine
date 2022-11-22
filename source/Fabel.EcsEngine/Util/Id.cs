namespace Fabel.EcsEngine.Util
{
	internal readonly record struct Id<T>(Guid id)
	{
		public override string ToString() => id.ToString();
		public static implicit operator Guid(Id<T> id) => id.id;
	}
}
