namespace AulaPatternsEstruturalAdapter.Adapter;

public class BusinnesLegado
{
    public string ExecutarRotinaContasPagar(string mes)
    {
        var result = AcessoSql.GetDadosPagar(mes);
        System.Console.WriteLine("\nProcessando regras de negócio contas a pagar...");
        Thread.Sleep(4000);
        return result;
    }

    public string ExecutarRotinaContasReceber(string mes)
    {
        var result = AcessoSql.GetDadosPagar(mes);
        System.Console.WriteLine("\nProcessando regras de negócio contas a receber...");
        Thread.Sleep(4000);
        return result;
    }
}

public class AcessoSql
{
    public static string GetDadosPagar(string mes)
    {
        Dictionary<string,string> dic = new Dictionary<string, string>();
        dic.Add("Junho","Junho\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");
        dic.Add("Julho","Julho\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");
        dic.Add("Agosto","Agosto\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");
        dic.Add("Setembro","Setembro\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");
        dic.Add("Outubro","Outubro\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");

        return dic[mes];
    }


    public static string GetDadosReceber(string mes)
    {
        Dictionary<string,string> dic = new Dictionary<string, string>();
        dic.Add("Junho","Junho\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");
        dic.Add("Julho","Julho\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");
        dic.Add("Agosto","Agosto\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");
        dic.Add("Setembro","Setembro\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");
        dic.Add("Outubro","Outubro\nCNPJ:09205036000186\nRazão Social: Anastacia Turismo\nValor:1200.00\nContato: (11) 1234-5555");

        return dic[mes];
    }
}