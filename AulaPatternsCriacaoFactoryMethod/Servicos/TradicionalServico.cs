using AulaPatternsCriacaoFactoryMethod.Interfaces;

namespace AulaPatternsCriacaoFactoryMethod.Servicos;

public class TradicionalServico : IServico
{
    public TradicionalServico()
    {
        System.Console.WriteLine("Serviço TRADICIONAL criado com sucesso.");
    }
    public void ExecutaCobrancaServico()
    {
        // logica para serviço TRADICINAL
    }
}
 