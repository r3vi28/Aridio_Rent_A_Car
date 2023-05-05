using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aridio_Rent_A_Car.Server.Context;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Routes;
using Aridio_Rent_A_Car.Shared.Wrapper;

namespace Restaurante.Server.Endpoints.TiposVehiculos;

using Respuesta = Result<TipoVehiculoRecord>;
using Request = TipoVehiculoRouteManager;

public class GetById : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;
    public GetById(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(TipoVehiculoRouteManager.GetById)]
    public override async Task<ActionResult<Respuesta>> HandleAsync([FromRoute] Request request, CancellationToken cancellationToken = default)
    {
        try
        {
            var tipo = await dbContext.TiposVehiculos
            .Where(t => t.Id == request.Id)
            .Select(tipo => tipo.ToRecord())
            .FirstOrDefaultAsync(cancellationToken);

            if(tipo == null)
            return Respuesta.Fail($"No fue posible encontrar el tipo de vehiculo '{request.Id}'");

            return Respuesta.Sucess(tipo);
        }
        catch(Exception ex){
            return Respuesta.Fail(ex.Message);
        }
    }

}