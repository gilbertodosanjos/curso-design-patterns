namespace CursoDesignPatterns.AulaClasseAbstradaHerancaInterfaces;

public class Ka : Carro
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
}
