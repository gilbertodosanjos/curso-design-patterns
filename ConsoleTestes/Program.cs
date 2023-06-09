
//using AulaPatternsCriacaoFactoryMethod;
//using AulaPatternsCriacaoFactoryAbstract;
// using AulaPatternsCriacaoSingleton;
//using AulaPatternsCriacaoBuilder;
//using AulaPatternsCriacaoPrototype;
//using AulaPatternsEstruturalAdapter.Adapter;

//using AulaPatternsEstruturalBridge;
//using AulaPatternsEstruturalBridge.Abstracao;
//using AulaPatternsEstruturalBridge.Implementacao;

namespace ExemploDI
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //AulaPatternsCriacaoFactoryAbstract
            System.Console.WriteLine("Iniciando o robô de consulta");
            Client  cliente  = new Client();
            cliente.ConsultarRotinaAluno(1);
             System.Console.WriteLine("Finalizando o robô de consulta");
             //AulaPatternsCriacaoFactoryAbstract */


            //AulaPatternsCriacaoSingleton
            // System.Console.WriteLine("Iniciando o robô de consulta");
            // Client  cliente  = new Client();
            // cliente.ConsumirDB();
            // System.Console.WriteLine("Finalizando o robô de consulta");
            //AulaPatternsCriacaoSingleton 

           /*  //AulaPatternsCriacaoSingleton
            System.Console.WriteLine("Iniciando o robô de consulta");
            Client  cliente  = new Client();
            cliente.ConsumirDados();
            System.Console.WriteLine("Finalizando o robô de consulta");
            //AulaPatternsCriacaoSingleton  */


           /*  //AulaPatternsCriacaoPrototype
            System.Console.WriteLine("Iniciando o robô de consulta");
            Cliente cliente  =  new Cliente();
            cliente.Consumir();
            System.Console.WriteLine("Finalizando o robô de consulta");
            //AulaPatternsCriacaoPrototype   */

             /* //AulaPatternsEstruturalAdapter
            CloudComputingClient cloud = new CloudComputingClient();
            cloud.ProcessarContas("Setembro");
            //AulaPatternsEstruturalAdapter */

            /* //AulaPatternsEstruturalFlyweigth
            System.Console.WriteLine("Iniciando o robô de consulta");
            Client cliente = new Client();
            cliente.ConsulirFlyweigths();
            System.Console.WriteLine("Finalizando o robô de consulta");
            //AulaPatternsEstruturalFlyweigth  */

            /* //AulaPatternsEstruturalBridge    
            System.Console.WriteLine("Iniciando o robô de consulta");
            Client cliente = new Client();

             for (var i = 0; i < 20; i++)
             {
                if (i%2>0)
                {
                    cliente.Material = new CanetaEsferografica();
                }else
                {
                    cliente.Material = new PincelMarcador();
                }

                if (i%2>0)
                {
                    cliente.Material.CorImplementacao = new Azul();
                }
                else if (i%3>0)
                {
                    cliente.Material.CorImplementacao = new Preto();
                }
                else
                {
                     cliente.Material.CorImplementacao = new Vermelho();
                }
                 cliente.ConsultarCanetasPineisNoEstoque();
                 System.Console.WriteLine($"Passo {i} de 20 do robô de consulta");
             }
            System.Console.WriteLine("Finalizando o robô de consulta"); */
        }
    }
}




