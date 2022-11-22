using Fabel.EcsEngine.Demo.Component;

namespace Fabel.EcsEngine.Demo.Tuples
{
	internal class NameTuple : Core.Tuple
	{
		public NameComponent NameComponent;

		public NameTuple(NameComponent nameComponent)
		{
			NameComponent = nameComponent;
		}
	}
}
