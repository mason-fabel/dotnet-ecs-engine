namespace Fabel.EcsEngine.Demo.Component
{
	internal class NameComponent : BaseComponent
	{
		public string Name;

		public NameComponent(Core.Entity parent, string name) : base(parent)
		{
			Name = name;
		}
	}
}
