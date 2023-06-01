using AulaPatternsEstruturalAdapter.Adapter.Interfaces;

namespace AulaPatternsEstruturalAdapter.Adapter;

public class Adapter: IAdapter
{
    BusinnesLegado _legado;
    public Adapter(BusinnesLegado legado)
    {
        _legado = legado;
    }

    public string ExecutarRotinaContasPagar(string mes)
    {
        return _legado.ExecutarRotinaContasPagar(mes);
    }
    public string ExecutarRotinaContasReceber(string mes) 
    {
        return _legado.ExecutarRotinaContasReceber(mes);
    }
}
