using CursoDesignPatterns.AulaIndexadores;
using CursoDesignPatterns.AulaPatternsCriacao.FactoryMethod;


//Inicio:AulaIndexadores
/* 

Indexadores indexador  = new Indexadores();

int[] lista  = {1,2,3,4};

for (int i = 0; i < lista.Length; i++)
{
    indexador[i] = new Indexadores($"indexador {i}" );
}         

for (int i = 0; i < lista.Length; i++)
{
    System.Console.WriteLine( indexador[i].Mensagem);
} 
//Final:AulaIndexadores

//Inicio:AulaClasseAbstradaHerancaInterfaces
using CursoDesignPatterns.AulaClasseAbstradaHerancaInterfaces;

Palio palio =  new Palio();
var ano  = palio.Ano;
var modelo  = palio.Modelo;
//Final:AulaClasseAbstradaHerancaInterfaces
*/




Client client =  new Client();
client.ExecutarProduto();