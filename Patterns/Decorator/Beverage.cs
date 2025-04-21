namespace Patterns.Decorator;

public abstract class Beverage
{
    public enum Size
    {
        Tall,
        Grande,
        Venti
    };

    private Size size = Size.Venti;
    
    protected string Description { get; init; } = "Unknown Beverage";

    public virtual string GetDescription()
    {
        return Description;
    }

    public abstract decimal Cost();

    public void SetSize(Size newSize)
    {
        size = newSize;
    }

    public virtual Size GetSize()
    {
        return size;
    }
}