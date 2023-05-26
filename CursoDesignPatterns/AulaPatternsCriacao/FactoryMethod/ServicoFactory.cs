using CursoDesignPatterns.AulaPatternsCriacao.Enuns;
using CursoDesignPatterns.AulaPatternsCriacao.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.AulaPatternsCriacao.FactoryMethod;

public abstract class ServicoFactory
{
    public abstract IServico  FabricaProduto(eTiposServicos tiposServicos);
}
