using AulaPatternsEstruturalFlyweigth.Model;
namespace AulaPatternsEstruturalFlyweigth.Flyweigths;

public class Cinza: EspacoNave
{
    public Cinza()
    {
        this.condicao = "voando em linha reta";
        this.acao = "disparando lasers";
    }
    public override void Exibir (string cor,string tamanho)
    {
        this.cor = cor;
        this.tamanho  =  tamanho;
        System.Console.WriteLine($"Nave {this.tamanho}  e {this.cor}-{this.condicao}-{this.acao}");
    }
}
