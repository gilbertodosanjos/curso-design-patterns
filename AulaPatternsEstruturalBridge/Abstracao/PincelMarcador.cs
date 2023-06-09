using  AulaPatternsEstruturalBridge.Abstracao.Interfaces;
using AulaPatternsEstruturalBridge.Implementacao.Interfaces;

namespace AulaPatternsEstruturalBridge.Abstracao;

public class PincelMarcador : IMaterial
{
    public ICor CorImplementacao {get; set ;}

    public  string ConsultarNoEstoque ()
    {
        return this.CorImplementacao.ConsultarQuantidadePorCor("Pincel Marcador");
    }

}
