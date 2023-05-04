using System.ComponentModel.DataAnnotations;
using Aridio_Rent_A_Car.Shared.Records;
using Aridio_Rent_A_Car.Shared.Requests;

namespace Aridio_Rent_A_Car.Server.Models;

public class Reserva
{
    [Key]
    public int Id { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public int VehiculoId { get; set; }
    public virtual Vehiculo Vehiculo { get; set; } = null!;
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; } = null!;
    public int Dias { get; set; }
    public decimal PrecioTotal { get; set; }
    public bool Pagado { get; set; }
    public int FormaDePagoId { get; set; }
    public virtual FormaDePago FormaDePago { get; set; } = null!;
    public bool Cancelado { get; set; }

    public static Reserva Crear(ReservaCreateRequest request)
    {
        return new Reserva(){
            FechaInicio = request.FechaInicio,
            FechaFin = request.FechaFin,
            VehiculoId = request.VehiculoId,
            ClienteId = request.ClienteId,
            Dias = request.Dias,
            PrecioTotal = request.PrecioTotal,
            Pagado = request.Pagado,
            FormaDePagoId = request.FormaDePagoId,
            Cancelado = request.Cancelado
        };
    }

    public void Modificar(ReservaUpdateRequest request)
    {
        if(FechaInicio != request.FechaInicio)
            FechaInicio = request.FechaInicio;
        if(FechaFin != request.FechaFin)
            FechaFin = request.FechaFin;
        if(VehiculoId != request.VehiculoId)
            VehiculoId = request.VehiculoId;
        if(ClienteId != request.ClienteId)
            ClienteId = request.ClienteId;
        if(Dias != request.Dias)
            Dias = request.Dias;
        if(PrecioTotal != request.PrecioTotal)
            PrecioTotal = request.PrecioTotal;
        if(Pagado != request.Pagado)
            Pagado = request.Pagado;
        if(FormaDePagoId != request.FormaDePagoId)
            FormaDePagoId = request.FormaDePagoId;
        if(Cancelado != request.Cancelado)
            Cancelado = request.Cancelado;
    }

    public ReservaRecord ToRecord()
    {
        return new ReservaRecord(Id, FechaInicio, FechaFin, VehiculoId, Vehiculo.ToRecord(), ClienteId, Cliente.ToRecord(), Dias, PrecioTotal, Pagado, FormaDePagoId, FormaDePago.ToRecord(), Cancelado);
    }
}
