
using System.ComponentModel.DataAnnotations;

namespace Aridio_Rent_A_Car.Shared.Requests;

public class TipoVehiculoUpdateRequest : TipoVehiculoCreateRequest
{
    [Required(ErrorMessage = "Ingrese un Id valido")    ]
    public int Id { get; set; }
}
