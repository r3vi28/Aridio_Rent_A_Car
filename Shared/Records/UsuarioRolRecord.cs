
namespace Aridio_Rent_A_Car.Shared.Records;

public class UsuarioRolRecord
{
    public UsuarioRolRecord()
    {
    }

    public UsuarioRolRecord(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
}
