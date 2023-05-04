using System.ComponentModel.DataAnnotations;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Requests;

namespace Aridio_Rent_A_Car.Server.Models;

public class Vehiculo
{
    [Key]
    public int Id { get; set; }
    public string Marca { get; set; } = null!;
    public int Año { get; set; }
    public int TipoVehiculoId { get; set; }
    public virtual TipoVehiculo TipoVehiculo { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string NumeroPlaca { get; set; } = null!;
    public decimal PrecioPorDia { get; set; }
    public int EstadoVehiculoId { get; set; }
    public virtual EstadoVehiculo Estado { get; set; } = null!;

    public static Vehiculo Crear(VehiculoCreateRequest request)
    {
        return new Vehiculo(){
            Marca = request.Marca,
            Año = request.Año,
            TipoVehiculoId = request.TipoVehiculoId,
            Color = request.Color,
            NumeroPlaca = request.NumeroPlaca,
            PrecioPorDia = request.PrecioPorDia,
            EstadoVehiculoId = request.EstadoVehiculoId
        };
    }

    public void Modificar(VehiculoUpdateRequest request)
    {
        if(Marca != request.Marca)
            Marca = request.Marca;
        if(Año != request.Año)
            Año = request.Año;
        if(TipoVehiculoId != request.TipoVehiculoId)
            TipoVehiculoId = request.TipoVehiculoId;
        if(Color != request.Color)
            Color = request.Color;
        if(NumeroPlaca != request.NumeroPlaca)
            NumeroPlaca = request.NumeroPlaca;
        if(PrecioPorDia != request.PrecioPorDia)
            PrecioPorDia = request.PrecioPorDia;
        if(EstadoVehiculoId != request.EstadoVehiculoId)
            EstadoVehiculoId = request.EstadoVehiculoId;
    }

    public VehiculoRecord ToRecord()
    {
        return new VehiculoRecord(Id, Marca, Año, TipoVehiculoId, TipoVehiculo.ToRecord(), Color, NumeroPlaca, PrecioPorDia, EstadoVehiculoId, Estado.ToRecord());
    }
}
