using Ardalis.ApiEndpoints;
using Aridio_Rent_A_Car.Server.Context;
using Aridio_Rent_A_Car.Shared.Routes;
using Aridio_Rent_A_Car.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aridio_Rent_A_Car.Server.Endpoints.TiposVehiculos;

using Respuesta = Result<int>;
using Request = TipoVehiculoRouteManager;

public class Delete : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;
    public Delete(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpDelete(TipoVehiculoRouteManager.BASE + "{id:int}")]
    public override async Task<ActionResult<Respuesta>> HandleAsync([FromRoute] Request request, CancellationToken cancellationToken = default)
    {
        try
        {
            var tipo = await dbContext.TiposVehiculos.FindAsync(request.Id);
            if(tipo == null)
                return Respuesta.Fail($"No fue posible encontrar el tipo de vehiculo con el id '{request.Id}'");
            dbContext.TiposVehiculos.Remove(tipo);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Respuesta.Sucess(tipo.Id);
        }
        catch(Exception ex)
        {
            return Respuesta.Fail(ex.Message);
        }
    }
}