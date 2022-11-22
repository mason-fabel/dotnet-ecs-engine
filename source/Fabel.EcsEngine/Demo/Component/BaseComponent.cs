using Fabel.EcsEngine.Util;

namespace Fabel.EcsEngine.Demo.Component
{
	internal class BaseComponent : Core.Component
	{
		private readonly Id<Core.Component> _Id;
		private readonly Id<Core.Entity> _EntityId;

		public BaseComponent(Core.Entity parent)
		{
			_Id = new Id<Core.Component>(Guid.NewGuid());
			_EntityId = parent.Id;
		}

		public override Id<Core.Component> Id => _Id;
		public override Id<Core.Entity> EntityId => _EntityId;
	}
}
