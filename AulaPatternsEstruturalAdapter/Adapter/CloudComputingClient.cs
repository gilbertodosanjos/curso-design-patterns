using AulaPatternsEstruturalAdapter.Adapter.Interfaces;

namespace AulaPatternsEstruturalAdapter.Adapter;

public class CloudComputingClient
{
   IAdapter _adapter;

    public CloudComputingClient()
    {
        _adapter = new Adapter(new BusinnesLegado());
    }

    public void ProcessarContas(string mes)
    {
        
        System.Console.WriteLine("Processando camada cloud computing conta a pagar...");
        Thread.Sleep(4000);
        string result =_adapter.ExecutarRotinaContasPagar(mes);
        System.Console.WriteLine(result);

        System.Console.WriteLine(new String('-',40));

        System.Console.WriteLine("Processando camada cloud computing conta a receber...");
        Thread.Sleep(4000);
        result = _adapter.ExecutarRotinaContasReceber(mes);
        System.Console.WriteLine(result);

        System.Console.WriteLine("\nProcessandofinalizado");
        Thread.Sleep(4000);

    }
}
