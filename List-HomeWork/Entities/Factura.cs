using System;

namespace List_HomeWork.Entities;

public class Factura
{
    public int Id { get; set; }
    public string NumeroFactura { get; set; } = String.Empty;
    public string Cliente { get; set; } = String.Empty;
    public double Total { get; set; }
    public bool Pagada { get; set; }
}
