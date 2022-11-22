using Fabel.EcsEngine.Demo.Component;
using Fabel.EcsEngine.Demo.Tuples;
using Fabel.EcsEngine.Util;

namespace Fabel.EcsEngine.Core
{
	internal class EntityAdmin
	{
		private readonly IDictionary<Id<Entity>, Entity> Entities;
		private readonly IList<Component> Components;
		private readonly IList<System> Systems;

		public EntityAdmin()
		{
			Entities = new Dictionary<Id<Entity>, Entity>();
			Components = new List<Component>();
			Systems = new List<System>();
		}

		public bool RegisterEntity(Entity entity)
		{
			if (Entities.ContainsKey(entity.Id))
			{
				return false;
			}

			Entities[entity.Id] = entity;

			return true;
		}

		public bool RegisterComponent(Id<Entity> entityId, Id<Component> componentId, Component component)
		{
			var entity = GetEntityById(entityId);
			if (entity == null)
			{
				return false;
			}

			if (!entity.Components.TryAdd(componentId, component))
			{
				return false;
			}

			Components.Add(component);

			return true;
		}

		public bool RegisterSystem(System system)
		{
			Systems.Add(system);

			return true;
		}

		public Entity? GetEntityById(Id<Entity> entityId)
		{
			Entities.TryGetValue(entityId, out Entity? value);

			return value;
		}

		public IEnumerable<NameTuple> GetNameTuples()
		{
			return Components.GroupBy(component => component.EntityId)
				.ToDictionary(group => group.Key, group => group.ToList())
				.Where(kvp => kvp.Value.Select(component => component as NameComponent).Where(component => component != null).Count() == 1)
				.Select(kvp => new NameTuple(nameComponent: kvp.Value.Single() as NameComponent));
		}

		public bool Tick(long frame)
		{
			return Systems
				.Select(system => system.Tick(this, frame))
				.Aggregate(AggregateUtils.AllTrue);
		}
	}
}
