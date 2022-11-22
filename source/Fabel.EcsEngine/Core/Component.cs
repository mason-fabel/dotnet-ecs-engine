using Fabel.EcsEngine.Util;

namespace Fabel.EcsEngine.Core
{
	internal abstract class Component
	{
		public abstract Id<Component> Id { get; }
		public abstract Id<Entity> EntityId { get; }
	}
}
