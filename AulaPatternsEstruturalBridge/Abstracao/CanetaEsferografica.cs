
using  AulaPatternsEstruturalBridge.Abstracao.Interfaces;
using AulaPatternsEstruturalBridge.Implementacao.Interfaces;

namespace AulaPatternsEstruturalBridge.Abstracao;

public class CanetaEsferografica : IMaterial
{
    public ICor CorImplementacao {get; set ;}

    public  string ConsultarNoEstoque ()
    {
        return this.CorImplementacao.ConsultarQuantidadePorCor("Caneta Esferografica");
    }



}
