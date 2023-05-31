using AulaPatternsCriacaoFactoryAbstract.ParteCriacao.Factorys;
using AulaPatternsCriacaoFactoryAbstract.ParteCriacao.Intefaces;

namespace AulaPatternsCriacaoFactoryAbstract;

public class Client
{

    public void ConsultarRotinaAluno(int rotina)
    {
        IFactory factory;

        if (rotina == 1)
             factory = new SegundaQuintaFactory();

        if (rotina == 2)
             factory = new TercaSextaFactory();
        
         if (rotina == 3)
             factory = new QuartaSabadoFactory();

    }


}
