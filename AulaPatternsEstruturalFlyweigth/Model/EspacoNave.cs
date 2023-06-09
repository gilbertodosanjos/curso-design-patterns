namespace AulaPatternsEstruturalFlyweigth.Model;

public abstract class EspacoNave
{
    //variáveis intrinsicas - não muda o estado
    protected string condicao;
    protected string acao;

    //propriedades estrinsicas -  muda o estado
    public string  cor { get; set; }
    public string tamanho { get; set; }

    public abstract void Exibir (string cor,string tamanho);

}
