using AulaPatternsCriacaoFactoryAbstract.ParteCriacao.Intefaces;
using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

namespace AulaPatternsCriacaoFactoryAbstract.ParteCriacao.Factorys;

public class QuartaSabadoFactory : IFactory
{
    public QuartaSabadoFactory()
    {
        this.ObterRotinaDiaria();
    }
    public void ObterRotinaDiaria()
    {
        DietaQuartaSabado  dieta  = new DietaQuartaSabado();
        TreinoQuartaSabado treino =  new TreinoQuartaSabado();

        dieta.obterAlimentacao();
        treino.obterTreino();

        System.Console.WriteLine("Factory de quarta e sábado criado.");

    }
}
