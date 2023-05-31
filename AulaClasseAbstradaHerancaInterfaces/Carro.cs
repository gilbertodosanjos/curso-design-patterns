namespace AulaClasseAbstradaHerancaInterfaces;

public abstract class Carro
{
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public string GetModelAno()
    {
        return $"Model:{Modelo}\nAno:{Ano}";
    }


    //método abstrado deverá ser implementado na classe filha
    public abstract void SalvarModelo(string modelo);

    // o método do tipo virtual poderá ser implementado na classe filha
    // porém não é obrigatório e ele poderá ser modificado, usar o override
    // na classe filha para implementar a modificação, esse é o conceito de
    // POLIMORFISMO "diferentes formas"
    public virtual void SalvarAno(int ano)
    {
        this.Ano = ano;
    }


}
