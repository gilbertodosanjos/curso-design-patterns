using AulaPatternsCriacaoFactoryMethod.Interfaces;

namespace AulaPatternsCriacaoFactoryMethod.Servicos;

public class MasterServico : IServico
{
    public MasterServico()
    {
        System.Console.WriteLine("Produto MASTER criado com sucesso");
        
    }

    public void ExecutaCobrancaServico()
    {
          // logica de cobrança de serviços para a cobertura Master
    }
}
