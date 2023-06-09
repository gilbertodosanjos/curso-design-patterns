using AulaPatternsEstruturalBridge.Abstracao.Interfaces;

namespace AulaPatternsEstruturalBridge;

public class Client
{

    public IMaterial Material { get; set; }

    public void ConsultarCanetasPineisNoEstoque()
    {
        System.Console.WriteLine(this.Material.ConsultarNoEstoque());
    }
}
