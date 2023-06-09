using AulaPatternsEstruturalBridge.Implementacao.Interfaces;

namespace AulaPatternsEstruturalBridge.Abstracao.Interfaces;

public interface IMaterial
{
    public ICor CorImplementacao {get; set ;}

    string ConsultarNoEstoque ();
}
