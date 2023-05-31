using AulaPatternsCriacaoFactoryMethod.Enuns;

namespace AulaPatternsCriacaoFactoryMethod;

public class Client
{
    public void ExecutarProduto()
    {
        var client = new SelecionaServico();
        bool continuar  = true;

        while(continuar)
        {
            System.Console.WriteLine("Selecione o tipo de serviço");
            System.Console.WriteLine("1001 - Tradicional");
            System.Console.WriteLine("1002 - Premium");
            System.Console.WriteLine("1003 - Master");
            System.Console.WriteLine("1004 - Cobertura");

            System.Console.Write("Digite o número do serviço que deseja cobrar: ");
            int tipoServiço  = Convert.ToInt32(Console.ReadLine());

            var serviço  =  client.FabricaProduto((eTiposServicos)tipoServiço);

            System.Console.Write("Deseja calcular outro serviço:(1-sim oi 2- não): ");
            int resp  = Convert.ToInt32(Console.ReadLine());

            continuar = resp == 1;


        }
    }
}
