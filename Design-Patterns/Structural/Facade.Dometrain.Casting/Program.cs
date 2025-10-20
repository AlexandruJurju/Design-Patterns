// client code
using Facade.Dometrain.Casting;

var castingFacade = new CastingFacade(
    new DeviceExplorer());

await castingFacade.CastAsync(
    deviceId: Guid.NewGuid(),
    videoId: Guid.NewGuid());