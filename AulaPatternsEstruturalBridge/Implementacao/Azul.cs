
using AulaPatternsEstruturalBridge.Implementacao.Interfaces;

namespace AulaPatternsEstruturalBridge.Implementacao;

public class Azul : ICor
{
    public string ConsultarQuantidadePorCor(string tipoAbstracao = "nulo")
    {
        //implementa compelxidade de consultar no banco de dados a quantidade por cor
        var random  =  new Random();

        return $"Existem {random.Next()} para {tipoAbstracao} de cor azul no estoque";

    }
}
