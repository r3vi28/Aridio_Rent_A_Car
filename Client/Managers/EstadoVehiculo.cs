using Aridio_Rent_A_Car.Shared.Wrapper;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Routes;
using Restaurante.Client.Extensions;
using Aridio_Rent_A_Car.Shared.Requests;
using System.Net.Http.Json;

namespace Restaurante.Client.Managers;

public interface IEstadoVehiculoManager
{
    Task<ResultList<EstadoVehiculoRecord>> GetAsync();
    Task<Result<int>> CreateAsync(EstadoVehiculoCreateRequest request);
    Task<Result<EstadoVehiculoRecord>> GetByIdAsync(int Id);
    Task<Result> DeleteAsync(int id);
}

public class EstadoVehiculoManager : IEstadoVehiculoManager
{
    private readonly HttpClient httpClient;

    public EstadoVehiculoManager(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<ResultList<EstadoVehiculoRecord>> GetAsync()
    {
        try
        {
            var response = await httpClient.GetAsync(EstadoVehiculoRouteManager.BASE);
            var resultado = await response.ToResultList<EstadoVehiculoRecord>();
            return resultado;
        }
        catch (Exception e)
        {
            return ResultList<EstadoVehiculoRecord>.Fail(e.Message);
        }
    }

    public async Task<Result<int>> CreateAsync(EstadoVehiculoCreateRequest request)
    {
        var response = await httpClient.PostAsJsonAsync(EstadoVehiculoRouteManager.BASE,request);
        return await response.ToResult<int>();
    }

    public async Task<Result<EstadoVehiculoRecord>> GetByIdAsync(int Id)
    {
        var response = await httpClient.GetAsync(EstadoVehiculoRouteManager.BuildRoute(Id));
        return await response.ToResult<EstadoVehiculoRecord>();
    }

    public async Task<Result> DeleteAsync(int id)
{
    try
    {
        var response = await httpClient.DeleteAsync(EstadoVehiculoRouteManager.BuildRoute(id));
        var resultado = await response.ToResult<EstadoVehiculoRecord>();
        return resultado;
    }
    catch (Exception e)
    {
        return Result.Fail(e.Message);
    }
}

}