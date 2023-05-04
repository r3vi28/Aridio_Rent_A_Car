
namespace Aridio_Rent_A_Car.Shared.Records;

public class VehiculoRecord
{
    public VehiculoRecord()
    {
    }

    public VehiculoRecord(int id, string marca, int año, int tipoVehiculoId, TipoVehiculoRecord tipoVehiculo, string color, string numeroPlaca, decimal precioPorDia, int estadoVehiculoId, EstadoVehiculoRecord estado)
    {
        Id = id;
        Marca = marca;
        Año = año;
        TipoVehiculoId = tipoVehiculoId;
        TipoVehiculo = tipoVehiculo;
        Color = color;
        NumeroPlaca = numeroPlaca;
        PrecioPorDia = precioPorDia;
        EstadoVehiculoId = estadoVehiculoId;
        Estado = estado;
    }

    public int Id { get; set; }
    public string Marca { get; set; } = null!;
    public int Año { get; set; }
    public int TipoVehiculoId { get; set; }
    public virtual TipoVehiculoRecord TipoVehiculo { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string NumeroPlaca { get; set; } = null!;
    public decimal PrecioPorDia { get; set; }
    public int EstadoVehiculoId { get; set; }
    public virtual EstadoVehiculoRecord Estado { get; set; } = null!;
}