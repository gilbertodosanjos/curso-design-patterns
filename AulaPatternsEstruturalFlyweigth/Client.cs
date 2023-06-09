namespace AulaPatternsEstruturalFlyweigth;

public class Client
{
    List<string> coresTamanhos  = new List<string>()
    {
        "azul:pequena","cinza:media","vermelha:grande","azul:pequena","cinza:media","vermelha:grande",
        "azul:pequena","cinza:media","vermelha:grande"
    };
    public void ConsulirFlyweigths()
    {
        FlyweigthFactory factory =  new FlyweigthFactory();

        foreach (var item in coresTamanhos)
        {
            var cor  = item.Split(":")[0];
            var tamanho  = item.Split(":")[1];

            var espacoNave =  factory.GetEspacoNave(cor);

            espacoNave.Exibir(cor,tamanho);
        }
    }
}
