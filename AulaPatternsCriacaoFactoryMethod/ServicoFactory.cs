using AulaPatternsCriacaoFactoryMethod.Enuns;
using AulaPatternsCriacaoFactoryMethod.Interfaces;

namespace AulaPatternsCriacaoFactoryMethod;

public abstract class ServicoFactory
{
    public abstract IServico  FabricaProduto(eTiposServicos tiposServicos);
}
