using Fabel.EcsEngine.Demo.Tuples;
using Fabel.EcsEngine.Util;

namespace Fabel.EcsEngine.Core
{
	internal abstract class Entity
	{
		public abstract Id<Entity> Id { get; }

		public IDictionary<Id<Component>, Component> Components { get; }

		public Entity()
		{
			Components = new Dictionary<Id<Component>, Component>();
		}
	}
}
