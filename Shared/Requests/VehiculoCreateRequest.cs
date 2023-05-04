
using System.ComponentModel.DataAnnotations;

namespace Aridio_Rent_A_Car.Shared.Requests;

public class VehiculoCreateRequest
{
    [Required(ErrorMessage = "Ingrese la marca")]
    public string Marca { get; set; } = null!;
    [Required(ErrorMessage = "Ingrese el año")]
    public int Año { get; set; }
    [Required(ErrorMessage = "Ingrese un valor valido")]
    public int TipoVehiculoId { get; set; }
    public string Color { get; set; } = null!;
    [Required(ErrorMessage = "Ingrese una placa valida")]
    public string NumeroPlaca { get; set; } = null!;
    [Required(ErrorMessage = "Ingrese la marca")]
    public decimal PrecioPorDia { get; set; }
    public int EstadoVehiculoId { get; set; }
}
