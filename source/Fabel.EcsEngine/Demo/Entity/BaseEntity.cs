using Fabel.EcsEngine.Util;

namespace Fabel.EcsEngine.Demo.Entity
{
	internal class BaseEntity : Core.Entity
	{
		private readonly Id<Core.Entity> _Id;

		public BaseEntity()
		{
			_Id = new Id<Core.Entity>(Guid.NewGuid());
		}

		public override Id<Core.Entity> Id => _Id;
	}
}
