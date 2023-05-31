using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Interfaces;

namespace AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

public class TreinoTercaSexta : ITreino
{
    public TreinoTercaSexta()
    {
        this.obterTreino();
    }
    
    public void obterTreino()
    {
        System.Console.WriteLine("Treino terça e sexta feira. . .");
    }
}
