namespace CursoDesignPatterns.AulaClasseAbstradaHerancaInterfaces;

public class Palio : Carro, ICategoriaX
{
    public override void SalvarModelo(string modelo)
    {
        this.Modelo = modelo;
    }
    public override void SalvarAno(int ano)
    {
        System.Console.WriteLine("Lógica Carro Palio");
        base.SalvarAno(ano);
    }

    public void MotodoExclusivoCategoriaX(string entrada)
    {
        System.Console.WriteLine($"CategoriaX:{entrada}");
    }
}