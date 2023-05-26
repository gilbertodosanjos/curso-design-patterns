
using CursoDesignPatterns.AulaPatternsCriacao.FactoryMethod.Interfaces;


namespace CursoDesignPatterns.AulaPatternsCriacao.FactoryMethod.Servicos;

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
