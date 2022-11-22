using Fabel.EcsEngine.Core;
using Fabel.EcsEngine.Demo.Component;
using Fabel.EcsEngine.Demo.Entity;
using Fabel.EcsEngine.Demo.System;

var entityAdmin = new EntityAdmin();

var gameRunning = true;
var frameCount = 0;

entityAdmin.RegisterSystem(new NameSystem());

foreach (var i in Enumerable.Range(1, 10))
{
	var entity = new BaseEntity();
	entityAdmin.RegisterEntity(entity);

	// only put names on even index entities
	if (i % 2 == 0)
	{
		var nameComponent = new NameComponent(entity, $"Entity_{i:D3}");
		entityAdmin.RegisterComponent(entity.Id, nameComponent.Id, nameComponent);
	}
}

while (gameRunning)
{
	frameCount++;

	entityAdmin.Tick(frameCount);

	Console.ReadLine();
}
