
using AulaPatternsCriacaoSingleton.Singleton;

namespace AulaPatternsCriacaoSingleton;

public class Client
{
    public void ConsumirDB()
    {

        var instancia  =  ContextDB.Instancia;
        instancia.ExecutaQuery("select * from tabelaA");

        instancia  = ContextDB.Instancia;
        instancia.ExecutaQuery("insert into  tabelaB(campo1,campo2) , valies (1,2)");

        instancia  = ContextDB.Instancia;
        instancia.ExecutaQuery("delete * from tabelac where id  = 1");

    }
}
