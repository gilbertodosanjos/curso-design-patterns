using AulaPatternsCriacaoFactoryAbstract.ParteCriacao.Intefaces;
using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

namespace AulaPatternsCriacaoFactoryAbstract.ParteCriacao.Factorys;

public class SegundaQuintaFactory : IFactory
{
    public SegundaQuintaFactory()
    {
        this.ObterRotinaDiaria();
    }
    public void ObterRotinaDiaria()
    {
      
        DietaSegundaQuinta dieta = new DietaSegundaQuinta();
        TreinoSegundaQuinta treino  = new TreinoSegundaQuinta();

        dieta.obterAlimentacao();
        treino.obterTreino();
        
        System.Console.WriteLine("Factory segunda e quinta criado.");
    }
}
