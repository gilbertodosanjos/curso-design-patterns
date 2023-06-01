namespace AulaPatternsCriacaoPrototype;

public class Cliente
{
    public void Consumir()
    {
        GerenciadosVendasStudio gerenciador  = new GerenciadosVendasStudio();
        gerenciador["24m"] = new Studio("24m","FinanciamentoPrata",180000.00M);
        gerenciador["26m"] = new Studio("26m","FinanciamentoOuro",190000.00M);
        gerenciador["28m"] = new Studio("28m","FinanciamentoDiamante",220000.00M);

        StudioModel clone01 = gerenciador["24m"].clone();
        StudioModel clone02 = gerenciador["26m"].clone();
        StudioModel clone03 = gerenciador["28m"].clone();
    }
}
