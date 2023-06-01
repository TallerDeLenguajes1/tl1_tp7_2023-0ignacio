namespace espacioEmpleado;

public class empleado
{
    [Flags]
    enum cargos {
        Auxiliar = 0,
        Administrativo = 1,
        Ingeniero = 2,
        Especialista = 3,
        Investigador = 4
    }
    private string? Nombre;
    private string? Apellido;
    private DateTime FNac;
    private char Civil;
    private char Genero;
    private DateTime FIngreso;

    public empleado(int x, string Nombre, string Apellido, DateTime FNac, char Civil, char Genero, DateTime FIngreso)
    {
       
    }
}