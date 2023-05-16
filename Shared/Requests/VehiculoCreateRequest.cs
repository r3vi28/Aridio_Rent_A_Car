
using System.ComponentModel.DataAnnotations;

namespace Aridio_Rent_A_Car.Shared.Requests;

public class VehiculoCreateRequest
{
    [Required(ErrorMessage = "Ingrese la marca")]
    public string Marca { get; set; } = null!;
    [Required(ErrorMessage = "Ingrese el año")]
    public int Año { get; set; }
    [Required(ErrorMessage = "Ingrese un valor valido")]
    public string Modelo { get; set; } = null!;
    public string Color { get; set; } = null!;
    [Required(ErrorMessage = "Ingrese una placa valida")]
    public string NumeroPlaca { get; set; } = null!;
    [Required(ErrorMessage = "Ingrese la marca")]
    public decimal PrecioPorDia { get; set; }

    public bool Si {get; set;}
    public bool No {get; set;}



    public bool AireAcondicionado { get; set; }
    public bool Encendedor { get; set; }
    public bool Radio { get; set; }
    public bool Bateria { get; set; }
    public bool Limpiabrisas { get; set; }
    public bool Revista { get; set; }
    public bool Documentos { get; set; }
    public bool Micas { get; set; }
    public bool Asientos { get; set; }
    public bool GomaRepuesto { get; set; }
    public bool Placa { get; set; }
    public bool Vidrios { get; set; }
    public bool Llaveros { get; set; }
    public bool Antenas { get; set; }
    public bool Gatos { get; set; }
    public bool TapaGasolina { get; set; }
    public bool Cinturones { get; set; }
    public bool LlaveDeRuedas { get; set; }
    public bool Alfombras { get; set; }
    public bool Espejos { get; set; }
    public bool TapaDeBocinas { get; set; }
    public bool Bocinas { get; set; }
    public bool Logos { get; set; }
}
