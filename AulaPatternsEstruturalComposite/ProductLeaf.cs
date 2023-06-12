using AulaPatternsEstruturalComposite.Model;

namespace AulaPatternsEstruturalComposite;

public class ProductLeaf : ComponentModel
{
    private string _nome;
    private double _valor;

    public ProductLeaf(string nome, double valor)
    {
        _nome = nome;
        _valor = valor;
    }

    public override void Add(params ComponentModel[] components)
    {
       System.Console.WriteLine("Não é possível adicionar objetos a uma classe do tipo leaf");
    }

    public override ComponentModel GetChild(int index)
    {
        System.Console.WriteLine("Não é possível obter objetos em um objeto tipo leaf");
        return null;
    }

    public override double Operation()
    {
        System.Console.WriteLine($"Produto:{_nome}\valor:{_valor.ToString("C")}");
        System.Console.WriteLine(new string('-',40) );
        return _valor;
    }

    public override void Remove(ComponentModel componet)
    {
        System.Console.WriteLine("Não é possível remover itens objetos em um objeto tipo leaf");
    }
}
