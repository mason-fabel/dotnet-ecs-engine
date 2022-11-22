using Fabel.EcsEngine.Core;
using Fabel.EcsEngine.Demo.Tuples;

namespace Fabel.EcsEngine.Demo.System
{
	internal class NameSystem : Core.System
	{
		public override Type GetTuple() => typeof(NameTuple);

		public override bool Tick(EntityAdmin entityAdmin, long frame)
		{
			foreach (var tuple in entityAdmin.GetNameTuples())
			{
				Console.WriteLine($"[{frame}] Tick entity \"{tuple.NameComponent.Name}\"");
			}

			return true;
		}
	}
}
