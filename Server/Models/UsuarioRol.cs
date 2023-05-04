using System.ComponentModel.DataAnnotations;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Requests;

namespace Aridio_Rent_A_Car.Server.Models;

public class UsuarioRol
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;

    public static UsuarioRol Crear(UsuarioRolCreateRequest request)
    {
        return new UsuarioRol(){
            Nombre = request.Nombre
        };
    }

    public void Modificar(UsuarioRolUpdateRequest request)
    {
        if(Nombre != request.Nombre)
            Nombre = request.Nombre;
    }

    public UsuarioRolRecord ToRecord()
    {
        return new UsuarioRolRecord(Id, Nombre);
    }
}
