using AulaPatternsCriacaoFactoryAbstract.ParteCriacao.Intefaces;
using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

namespace AulaPatternsCriacaoFactoryAbstract.ParteCriacao.Factorys;

public class TercaSextaFactory : IFactory
{
    public TercaSextaFactory()
    {
        this.ObterRotinaDiaria();
    }
    public void ObterRotinaDiaria()
    {
        DietaTercaSexta dieta =  new DietaTercaSexta();
        TreinoTercaSexta treino =  new TreinoTercaSexta();

        dieta.obterAlimentacao();
        treino.obterTreino();

        System.Console.WriteLine("Factory de terça e sexta criado.");
    }
}
