
namespace Aridio_Rent_A_Car.Shared.Records;

public class EstadoVehiculoRecord
{
    public EstadoVehiculoRecord()
    {
    }

    public EstadoVehiculoRecord(int id, bool aireAcondicionado, bool encendedor, bool radio, bool bateria, bool limpiabrisas, bool revista, bool documentos, bool micas, bool asientos, bool gomaRepuesto, bool placa, bool vidrios, bool llaveros, bool antenas, bool gatos, bool tapaGasolina, bool cinturones, bool llaveDeRuedas, bool alfombras, bool espejos, bool tapaDeBocinas, bool bocinas, bool logos)
    {
        Id = id;
        AireAcondicionado = aireAcondicionado;
        Encendedor = encendedor;
        Radio = radio;
        Bateria = bateria;
        Limpiabrisas = limpiabrisas;
        Revista = revista;
        Documentos = documentos;
        Micas = micas;
        Asientos = asientos;
        GomaRepuesto = gomaRepuesto;
        Placa = placa;
        Vidrios = vidrios;
        Llaveros = llaveros;
        Antenas = antenas;
        Gatos = gatos;
        TapaGasolina = tapaGasolina;
        Cinturones = cinturones;
        LlaveDeRuedas = llaveDeRuedas;
        Alfombras = alfombras;
        Espejos = espejos;
        TapaDeBocinas = tapaDeBocinas;
        Bocinas = bocinas;
        Logos = logos;
    }

    public int Id { get; set; }
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
