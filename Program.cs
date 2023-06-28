using espacioEmpleado;
// See https://aka.ms/new-console-template for more information
double total = 0;
empleado nuevo;
List<empleado> listaEmpleados = new List<empleado>();
empleado Empleado = new empleado();

nuevo = Empleado.cargarEmpleado(Cargos.Auxiliar);
listaEmpleados.Add(nuevo);
nuevo = Empleado.cargarEmpleado(Cargos.Administrativo);
listaEmpleados.Add(nuevo);
nuevo = Empleado.cargarEmpleado(Cargos.Ingeniero);
listaEmpleados.Add(nuevo);

foreach (empleado emp in listaEmpleados)
{
    Console.WriteLine("Información del empleado:");
    Console.WriteLine($"Nombre: {emp.Nombre1} {emp.Apellido1}");
    Console.WriteLine($"Fecha de nacimiento: {emp.FNac1.ToShortDateString()}");
    Console.WriteLine($"Estado civil: {emp.Civil1}");
    Console.WriteLine($"Género: {emp.Genero1}");
    Console.WriteLine($"Fecha de ingreso: {emp.FIngreso1.ToShortDateString()}");
    Console.WriteLine($"Sueldo básico: {emp.SueldoBasico1.ToString("N2")}");
    Console.WriteLine($"Cargo: {emp.Cargo1}");
    Console.WriteLine("-----------------------------------------------------");
    total += emp.calcularSalario();
}

Console.WriteLine("Cantidad total a pagar:" + total.ToString("N2"));

double proxJubilacion = listaEmpleados.Min(nuevo => nuevo.calcularAniosJubilacion());

foreach (empleado emp in listaEmpleados)
{
    if(proxJubilacion == emp.calcularAniosJubilacion())
    {
        Console.WriteLine("Información del empleado:");
        Console.WriteLine($"Nombre: {emp.Nombre1} {emp.Apellido1}");
        Console.WriteLine($"Fecha de nacimiento: {emp.FNac1.ToShortDateString()}");
        Console.WriteLine($"Estado civil: {emp.Civil1}");
        Console.WriteLine($"Género: {emp.Genero1}");
        Console.WriteLine($"Fecha de ingreso: {emp.FIngreso1.ToShortDateString()}");
        Console.WriteLine($"Sueldo básico: {emp.SueldoBasico1.ToString("N2")}");
        Console.WriteLine($"Cargo: {emp.Cargo1}");
        Console.WriteLine($"Antiguedad: {emp.calcularAntiguedad().ToString("N0")}");
        Console.WriteLine($"Edad: {emp.calcularEdad().ToString("N0")}");
        Console.WriteLine($"Anios para jubilarse: {emp.calcularAniosJubilacion().ToString("N0")}");
        Console.WriteLine($"Sueldo: {emp.calcularSalario().ToString("N2")}");
    }
}