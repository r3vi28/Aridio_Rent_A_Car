
namespace Aridio_Rent_A_Car.Shared.Records;

public class TipoVehiculoRecord
{
    public TipoVehiculoRecord()
    {
    }

    public TipoVehiculoRecord(int id, string nombre, string descripcion)
    {
        Id = id;
        Nombre = nombre;
        Descripcion = descripcion;
    }

    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string Descripcion { get; set; } = null!;
}
