using Ardalis.ApiEndpoints;
using Aridio_Rent_A_Car.Server.Context;
using Aridio_Rent_A_Car.Shared.Routes;
using Aridio_Rent_A_Car.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aridio_Rent_A_Car.Server.Endpoints.EstadosVehiculos;

using Respuesta = Result<int>;
using Request = EstadoVehiculoRouteManager;

public class Delete : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;
    public Delete(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpDelete(EstadoVehiculoRouteManager.BASE + "{id:int}")]
    public override async Task<ActionResult<Respuesta>> HandleAsync([FromRoute] Request request, CancellationToken cancellationToken = default)
    {
        try
        {
            var estado = await dbContext.EstadosVehiculos.FindAsync(request.Id);
            if(estado == null)
                return Respuesta.Fail($"No fue posible encontrar el estado con el id '{request.Id}'");
            dbContext.EstadosVehiculos.Remove(estado);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Respuesta.Sucess(estado.Id);
        }
        catch(Exception ex)
        {
            return Respuesta.Fail(ex.Message);
        }
    }
}