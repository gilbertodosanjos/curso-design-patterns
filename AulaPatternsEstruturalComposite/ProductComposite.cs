using System.ComponentModel;
using AulaPatternsEstruturalComposite.Model;

namespace AulaPatternsEstruturalComposite;

public class ProductComposite : ComponentModel
{
    private List<ComponentModel> _components;

    public ProductComposite()
    {
        _components = new List<ComponentModel>();
    }

    public override void Add(params ComponentModel[] components)
    {
        _components.AddRange(components);
    }

    public override ComponentModel GetChild(int index)
    {
        if (_components.Count() == 0)
        {
            System.Console.WriteLine("Não possui produdos cadstrados");
            return null;

        }
        return _components[index];
    }

    public override double Operation()
    {
        double valorTotal = 0;

        for (var i = 0; i < _components.Count; i++)
        {
            var componet  = _components[i];
            var child  =  componet.GetChild(i);
            valorTotal = componet.Operation();
            
        }
        return valorTotal;
    }

    public override void Remove(ComponentModel componet)
    {
       _components.Remove(componet);
    }
}
