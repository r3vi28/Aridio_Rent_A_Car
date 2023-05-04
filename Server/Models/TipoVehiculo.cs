using System.ComponentModel.DataAnnotations;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Requests;

namespace Aridio_Rent_A_Car.Server.Models;

public class TipoVehiculo
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string Descripcion { get; set; } = null!;

    public static TipoVehiculo Crear(TipoVehiculoCreateRequest request)
    {
        return new TipoVehiculo(){
            Nombre = request.Nombre,
            Descripcion = request.Descripcion
        };
    }

    public void Modificar(TipoVehiculoUpdateRequest request)
    {
        if(Nombre != request.Nombre)
            Nombre = request.Nombre;
        if(Descripcion != request.Descripcion)
            Descripcion = request.Descripcion;
    }

    public TipoVehiculoRecord ToRecord()
    {
        return new TipoVehiculoRecord(Id, Nombre, Descripcion);
    }
}
