using System;

namespace List_HomeWork.Entities;

public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; } = String.Empty;
    public string Departamento { get; set; } = String.Empty;
    public double Salario { get; set; }
    public bool Activo { get; set; }
}
