using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Interfaces;

namespace AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

public class TreinoQuartaSabado : ITreino
{
    public TreinoQuartaSabado()
    {
        this.obterTreino();
    }
    
    public void obterTreino()
    {
         System.Console.WriteLine("Treino quarta e sábado. . .");
    }
}
