using Aridio_Rent_A_Car.Shared.Wrapper;
using Aridio_Rent_A_Car.Shared.Requests;
using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using Aridio_Rent_A_Car.Server.Context;
using Aridio_Rent_A_Car.Server.Models;
using Microsoft.EntityFrameworkCore;
using Aridio_Rent_A_Car.Shared.Routes;

namespace Aridio_Rent_A_Car.Server.Endpoints.TiposVehiculos;

using Request = TipoVehiculoCreateRequest;
using Respuesta = Result<int>;

public class Create : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public Create(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpPost(TipoVehiculoRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(Request request, CancellationToken cancellationToken = default)
    {
        try{
            #region Validaciones
            var tipo = await dbContext.TiposVehiculos.FirstOrDefaultAsync(t => t.Nombre.ToLower() == request.Nombre.ToLower(),cancellationToken);
            if(tipo != null)
                return Respuesta.Fail($"Ya existe un tipo de vehiculo con el nombre '({request.Nombre})'.");
            #endregion
            tipo = TipoVehiculo.Crear(request);
            dbContext.TiposVehiculos.Add(tipo);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Respuesta.Sucess(tipo.Id);
        }
        catch(Exception e){
            return Respuesta.Fail(e.Message);
        }
    }
}