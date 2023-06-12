namespace AulaPatternsEstruturalComposite.Model;

public abstract class ComponentModel
{
    public abstract double Operation();
    public abstract void Add(params ComponentModel[] components);
    public abstract void Remove(ComponentModel componet);
    public abstract ComponentModel GetChild(int index);

}
