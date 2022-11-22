namespace Fabel.EcsEngine.Core
{
	internal abstract class System
	{
		public abstract Type GetTuple();
		public abstract bool Tick(EntityAdmin entityAdmin, long frame);
	}
}
