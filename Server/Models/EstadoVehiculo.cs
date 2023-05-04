using System.ComponentModel.DataAnnotations;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Requests;

namespace Aridio_Rent_A_Car.Server.Models;

public class EstadoVehiculo
{
    [Key]
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

    public static EstadoVehiculo Crear(EstadoVehiculoCreateRequest request)
    {
        return new EstadoVehiculo
        {
            AireAcondicionado = request.AireAcondicionado,
            Encendedor = request.Encendedor,
            Radio = request.Radio,
            Bateria = request.Bateria,
            Limpiabrisas = request.Limpiabrisas,
            Revista = request.Revista,
            Documentos = request.Documentos,
            Micas = request.Micas,
            Asientos = request.Asientos,
            GomaRepuesto = request.GomaRepuesto,
            Placa = request.Placa,
            Vidrios = request.Vidrios,
            Llaveros = request.Llaveros,
            Antenas = request.Antenas,
            Gatos = request.Gatos,
            TapaGasolina = request.TapaGasolina,
            Cinturones = request.Cinturones,
            LlaveDeRuedas = request.LlaveDeRuedas,
            Alfombras = request.Alfombras,
            Espejos = request.Espejos,
            TapaDeBocinas = request.TapaDeBocinas,
            Bocinas = request.Bocinas,
            Logos = request.Logos
        };
    }

    public void Modificar(EstadoVehiculoUpdateRequest request)
    {
        if(AireAcondicionado != request.AireAcondicionado)
            AireAcondicionado = request.AireAcondicionado;
        if(Encendedor != request.Encendedor)
            Encendedor = request.Encendedor;
        if(Radio != request.Radio)
            Radio = request.Radio;
        if(Bateria != request.Bateria)
            Bateria = request.Bateria;
        if(Limpiabrisas != request.Limpiabrisas)
            Limpiabrisas = request.Limpiabrisas;
        if(Revista != request.Revista)
            Revista = request.Revista;
        if(Documentos != request.Documentos)
            Documentos = request.Documentos;
        if(Micas != request.Micas)
            Micas = request.Micas;
        if(Asientos != request.Asientos)
            Asientos = request.Asientos;
        if(GomaRepuesto != request.GomaRepuesto)
            GomaRepuesto = request.GomaRepuesto;
        if(Placa != request.Placa)
            Placa = request.Placa;
        if(Vidrios != request.Vidrios)
            Vidrios = request.Vidrios;
        if(Llaveros != request.Llaveros)
            Llaveros = request.Llaveros;
        if(Antenas != request.Antenas)
            Antenas = request.Antenas;
        if(Gatos != request.Gatos)
            Gatos = request.Gatos;
        if(TapaGasolina != request.TapaGasolina)
            TapaGasolina = request.TapaGasolina;
        if(Cinturones != request.Cinturones)
            Cinturones = request.Cinturones;
        if(LlaveDeRuedas != request.LlaveDeRuedas)
            LlaveDeRuedas = request.LlaveDeRuedas;
        if(Alfombras != request.Alfombras)
            Alfombras = request.Alfombras;
        if(Espejos != request.Espejos)
            Espejos = request.Espejos;
        if(TapaDeBocinas != request.TapaDeBocinas)
            TapaDeBocinas = request.TapaDeBocinas;
        if(Bocinas != request.Bocinas)
            Bocinas = request.Bocinas;
        if(Logos != request.Logos)
            Logos = request.Logos;
    }

    public EstadoVehiculoRecord ToRecord()
    {
        return new EstadoVehiculoRecord(Id, AireAcondicionado, Encendedor, Radio, Bateria, Limpiabrisas, Revista, Documentos, Micas, Asientos, GomaRepuesto, Placa, Vidrios, Llaveros, Antenas, Gatos, TapaGasolina, Cinturones, LlaveDeRuedas, Alfombras, Espejos, TapaDeBocinas, Bocinas, Logos);
    }
}
