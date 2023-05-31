using AulaPatternsCriacaoFactoryAbstract.ParteProduto.Interfaces;

namespace AulaPatternsCriacaoFactoryAbstract.ParteProduto.Produtos;

public class DietaTercaSexta : IDieta
{
    public DietaTercaSexta()
    {
        this.obterAlimentacao();
    }
    public void obterAlimentacao()
    {
        System.Console.WriteLine("Dieta de terça e sexta feira");
    }
}
