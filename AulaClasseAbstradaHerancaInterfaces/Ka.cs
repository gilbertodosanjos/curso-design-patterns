namespace AulaClasseAbstradaHerancaInterfaces;

public class Ka : Carro, ICategoriaY
{
    public override void SalvarModelo(string modelo)
    {
        this.Modelo = modelo;
    }

    public override void SalvarAno(int ano)
    {
        System.Console.WriteLine("Logica KA");
        base.SalvarAno(ano);
    }

    public void MorodtExclusivoCategoriaY(string entrada)
    {
       System.Console.WriteLine($"CategoriaY:{entrada}");
    }
}
