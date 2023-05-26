
namespace CursoDesignPatterns.AulaPropriedades;

public class Propriedades
{
    private double _segundos=0;

    public double Horas 
    { 
        set
        {
            if( value < 0 | value > 24)
            {
                System.Console.WriteLine("valor inválido...");
            }
            else
            {
                _segundos = value * 3600;
            }
        } 
        get
        {
            return _segundos;
        } 
    }

    
}
