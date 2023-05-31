using AulaPatternsCriacaoFactoryMethod.Interfaces;

namespace AulaPatternsCriacaoFactoryMethod.Servicos;

public class PremiumServico : IServico
{
    public PremiumServico()
    {
        System.Console.WriteLine("Produto PREMIUM criado com sucesso");   
    }
    public void ExecutaCobrancaServico()
    {
        // logica para produto PREMIUM
    }
}
