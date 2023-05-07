using Aridio_Rent_A_Car.Shared.Wrapper;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Routes;
using Aridio_Rent_A_Car.Client.Extensions;
using Aridio_Rent_A_Car.Shared.Requests;
using System.Net.Http.Json;

namespace Aridio_Rent_A_Car.Client.Managers;

public interface ITipoVehiculoManager
{
    Task<ResultList<TipoVehiculoRecord>> GetAsync();
    Task<Result<int>> CreateAsync(TipoVehiculoCreateRequest request);
    Task<Result<TipoVehiculoRecord>> GetByIdAsync(int Id);
    Task<Result> DeleteAsync(int id);
}

public class TipoVehiculoManager : ITipoVehiculoManager
{
    private readonly HttpClient httpClient;

    public TipoVehiculoManager(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<ResultList<TipoVehiculoRecord>> GetAsync()
    {
        try
        {
            var response = await httpClient.GetAsync(TipoVehiculoRouteManager.BASE);
            var resultado = await response.ToResultList<TipoVehiculoRecord>();
            return resultado;
        }
        catch (Exception e)
        {
            return ResultList<TipoVehiculoRecord>.Fail(e.Message);
        }
    }

    public async Task<Result<int>> CreateAsync(TipoVehiculoCreateRequest request)
    {
        var response = await httpClient.PostAsJsonAsync(TipoVehiculoRouteManager.BASE,request);
        return await response.ToResult<int>();
    }

    public async Task<Result<TipoVehiculoRecord>> GetByIdAsync(int Id)
    {
        var response = await httpClient.GetAsync(TipoVehiculoRouteManager.BuildRoute(Id));
        return await response.ToResult<TipoVehiculoRecord>();
    }

    public async Task<Result> DeleteAsync(int id)
{
    try
    {
        var response = await httpClient.DeleteAsync(TipoVehiculoRouteManager.BuildRoute(id));
        var resultado = await response.ToResult<TipoVehiculoRecord>();
        return resultado;
    }
    catch (Exception e)
    {
        return Result.Fail(e.Message);
    }
}

}