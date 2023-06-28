namespace espacioEmpleado;
public enum Cargos {
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class empleado
{
    private string? Nombre;
    private string? Apellido;
    private DateTime FNac;
    private string? Civil;
    private string? Genero;
    private DateTime FIngreso;
    private double SueldoBasico;
    private Cargos Cargo;

    public string? Nombre1 { get => Nombre; set => Nombre = value; }
    public string? Apellido1 { get => Apellido; set => Apellido = value; }
    public DateTime FNac1 { get => FNac; set => FNac = value; }
    public string? Civil1 { get => Civil; set => Civil = value; }
    public string? Genero1 { get => Genero; set => Genero = value; }
    public DateTime FIngreso1 { get => FIngreso; set => FIngreso = value; }
    public double SueldoBasico1 { get => SueldoBasico; set => SueldoBasico = value ;}
    public Cargos Cargo1 { get => Cargo; set => Cargo = value; }

    string[] nombres = {"Thomas", "Agustin", "Ignacio", "Camila", "Maria"};
    string[] apellidos = {"Gonzalez", "Medina", "Brito", "Ley", "Dip"};
    string[] estadoCivil = {"Casado/a", "Soltero/a"};
    string[] generos = {"Hombre", "Mujer"};

    public empleado cargarEmpleado(Cargos cargo)
    {
        empleado nuevo = new empleado();
        Random rnd = new Random();
        int auxN = rnd.Next(0,5);
        nuevo.Nombre1 = nombres[auxN];
        int auxA = rnd.Next(0,5);
        nuevo.Apellido1 = apellidos[auxA];
        int dia = rnd.Next(1, 31);
        int mes = rnd.Next(1, 13);
        int anio = rnd.Next(1950, 2006);
        nuevo.FNac1 = new DateTime(anio, mes, dia);
        int auxCi = rnd.Next(0,2);
        nuevo.Civil1 = estadoCivil[auxCi];
        int auxG = rnd.Next(0,2);
        nuevo.Genero1 = generos[auxG];
        dia = rnd.Next(1, 31);
        mes = rnd.Next(1, 13);
        anio = rnd.Next(1950, 2005);
        nuevo.FIngreso1 = new DateTime(anio, mes, dia);
        nuevo.SueldoBasico1 = rnd.NextDouble() * (200000 - 100000) + 100000;
        int auxC = rnd.Next(0,5);
        nuevo.Cargo1 = cargo;
        return nuevo;
    }

    public double calcularAntiguedad()
    {
        double antiguedad = 0;
        antiguedad = (DateTime.Now - FIngreso1).TotalDays;
        antiguedad /= 365;
        antiguedad = Math.Round(antiguedad);
        return antiguedad;
    }
    public double calcularEdad()
    {
        double edad = 0;
        edad = (DateTime.Now - FNac1).Days;
        edad /= 365;
        edad = Math.Round(edad);
        return edad;
    }
    public double calcularAniosJubilacion()
    {
        double anios = 0;
        if (Genero1 == "Hombre")
        {
            anios = 65 - calcularEdad();
        }else{
            anios = 60 - calcularEdad();
        }
        return anios;
    }
    public double calcularSalario(){
        double salario = 0, adicional = 0;
        double antiguedad = calcularAntiguedad();
        if (antiguedad < 21)
        {
            adicional = SueldoBasico1 * (antiguedad / 100);
        }else{
            adicional = SueldoBasico1 * 0.25;
        }
        if (Cargo1.Equals("Ingeniero") || Cargo1.Equals("Especialista"))
        {
            adicional += (adicional * 0.50);
        }
        if(Civil1.Equals("Casado/a"))
        {
            adicional += 15000;
        }
        salario = SueldoBasico + adicional;
        return salario;
    }
}