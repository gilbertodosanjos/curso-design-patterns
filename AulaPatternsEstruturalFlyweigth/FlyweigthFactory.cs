using AulaPatternsEstruturalFlyweigth.Model;
using AulaPatternsEstruturalFlyweigth.Flyweigths;

namespace AulaPatternsEstruturalFlyweigth;

public class FlyweigthFactory
{
    private Dictionary<string,EspacoNave> nave_lista = new Dictionary<string, EspacoNave>();

    public EspacoNave GetEspacoNave (string cor )
    {
        EspacoNave nave  = null;

        if(!string.IsNullOrEmpty(cor) && nave_lista.ContainsKey(cor))
        {
            nave  =  nave_lista[cor];
        }
        else
        {
            switch(cor)
            {
                case "azul":
                    nave = new Azul(); 
                    break;
                case "cinza":
                    nave  = new Cinza();
                    break;
                case "vermelha":
                    nave  =  new Vermelha();
                    break;
                 default:
                    break;              

            }
            if(nave != null)
                nave_lista.Add(cor,nave);
        }
        return nave;
    }
}
