using AulaPatternsEstruturalBridge.Implementacao.Interfaces;

namespace AulaPatternsEstruturalBridge.Implementacao;

public class Vermelho : ICor
{

    public string ConsultarQuantidadePorCor(string tipoAbstracao = "nulo")
    {
        //implementa compelxidade de consultar no banco de dados a quantidade por cor
        var random  =  new Random();
        //var quantidade  =  random.Next(100,500);

        return $"Existem {random.Next()} para {tipoAbstracao} de cor vermelha no estoque";

    }
}
