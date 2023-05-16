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
    public string Modelo { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string NumeroPlaca { get; set; } = null!;
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

    public static Vehiculo Crear(VehiculoCreateRequest request)
    {
        return new Vehiculo(){
            Marca = request.Marca,
            Año = request.Año,
            Modelo = request.Modelo,
            Color = request.Color,
            NumeroPlaca = request.NumeroPlaca,
            PrecioPorDia = request.PrecioPorDia,

            Si = request.Si,
            No = request.No,
            
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

    public void Modificar(VehiculoUpdateRequest request)
    {
        if(Marca != request.Marca)
            Marca = request.Marca;
        if(Año != request.Año)
            Año = request.Año;
        if(Modelo != request.Modelo)
            Modelo = request.Modelo;
        if(Color != request.Color)
            Color = request.Color;
        if(NumeroPlaca != request.NumeroPlaca)
            NumeroPlaca = request.NumeroPlaca;
        if(PrecioPorDia != request.PrecioPorDia)
            PrecioPorDia = request.PrecioPorDia;

        if(Si != request.Si)
            Si = request.Si;
        if(No != request.No)
            No = request.No;


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

    public VehiculoRecord ToRecord()
    {
        return new VehiculoRecord(Id, Marca, Año, Modelo, Color, NumeroPlaca, PrecioPorDia, Si, No, AireAcondicionado, Encendedor, Radio, Bateria, Limpiabrisas, Revista, Documentos, Micas, Asientos, GomaRepuesto, Placa, Vidrios, Llaveros, Antenas, Gatos, TapaGasolina, Cinturones, LlaveDeRuedas, Alfombras, Espejos, TapaDeBocinas, Bocinas, Logos);
    }
}
