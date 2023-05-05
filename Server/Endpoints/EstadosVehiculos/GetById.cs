using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aridio_Rent_A_Car.Server.Context;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Routes;
using Aridio_Rent_A_Car.Shared.Wrapper;

namespace Restaurante.Server.Endpoints.EstadosVehiculos;

using Respuesta = Result<EstadoVehiculoRecord>;
using Request = EstadoVehiculoRouteManager;

public class GetById : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;
    public GetById(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(EstadoVehiculoRouteManager.GetById)]
    public override async Task<ActionResult<Respuesta>> HandleAsync([FromRoute] Request request, CancellationToken cancellationToken = default)
    {
        try
        {
            var estado = await dbContext.EstadosVehiculos
            .Where(e => e.Id == request.Id)
            .Select(estado => estado.ToRecord())
            .FirstOrDefaultAsync(cancellationToken);

            if(estado == null)
            return Respuesta.Fail($"No fue posible encontrar el estado con el id '{request.Id}'");

            return Respuesta.Sucess(estado);
        }
        catch(Exception ex){
            return Respuesta.Fail(ex.Message);
        }
    }

}