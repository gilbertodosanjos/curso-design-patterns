
using AulaPatternsCriacaoFactoryMethod.Interfaces;


namespace AulaPatternsCriacaoFactoryMethod.Servicos;

public class CoberturaServico : IServico
{
    public CoberturaServico()
    {
        System.Console.WriteLine("Produto COBERTURA criado com sucesso");
    }
    public void ExecutaCobrancaServico()
    {
          // logica de cobrança de serviços para a COBERTURA
    }
}
