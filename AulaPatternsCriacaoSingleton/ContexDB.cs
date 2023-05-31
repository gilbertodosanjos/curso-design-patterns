

namespace AulaPatternsCriacaoSingleton.Singleton;

public class ContextDB
{
    private static  ContextDB _instancia = null;

    private ContextDB(){}
    public static ContextDB Instancia 
    { 
        get
        {
            if(_instancia == null)
            {
                _instancia = new ContextDB();
                System.Console.WriteLine("Instância ContexDB criada co sucesso!");
            }
            return _instancia;
        }
    }

    public void ExecutaQuery(string query)
    {
        System.Console.WriteLine(query);
    }
}
