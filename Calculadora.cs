namespace espacioCalculadora;

public class Calculadora
{
    private double dato;  

    public Calculadora()
    {
        dato = 0;
    }

    public double Resultado
    {
        get{
            return dato;
        }
    }

    public void Suma(double sumando)
    {
        dato += sumando;
    }
}