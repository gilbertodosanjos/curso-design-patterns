using CursoDesignPatterns.AulaPatternsCriacao.Enuns;
using CursoDesignPatterns.AulaPatternsCriacao.FactoryMethod.Interfaces;
using CursoDesignPatterns.AulaPatternsCriacao.FactoryMethod.Servicos;

namespace CursoDesignPatterns.AulaPatternsCriacao.FactoryMethod;

public class SelecionaServico : ServicoFactory
{
    public override IServico FabricaProduto(eTiposServicos tiposServicos)
    {
        switch(tiposServicos)
        {
            case eTiposServicos.tradicional:
                return new  TradicionalServico();
            case eTiposServicos.premium:
                return new PremiumServico();
            case eTiposServicos.master:
                return new MasterServico();
            case eTiposServicos.cobertura:
                return new CoberturaServico();
            default:
                return null;
            
        }
    }
}
