using AulaPatternsEstruturalComposite.Model;

namespace AulaPatternsEstruturalComposite;

public class Client
{
    public void EfetuarCompra()
    {
        ComponentModel product01 =  new ProductLeaf("Camiseta Battiman",30.00);
        ComponentModel product02 =  new ProductLeaf("Camiseta",20.00);
        ComponentModel product03 =  new ProductLeaf("Calça",50.00);
        ComponentModel product04 =  new ProductLeaf("Jaqueta",115.00);

        ComponentModel smallBox = new ProductComposite();
        smallBox.Add(product01,product02,product03);

        ComponentModel bigBox = new ProductComposite();
        bigBox.Add(smallBox,product04);

        var valorTotal = bigBox.Operation();

        System.Console.WriteLine($"\nValorTotal:{valorTotal.ToString("C")}" );

    }
}
