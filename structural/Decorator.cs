namespace structural;

// Component
public abstract class Component
{
    // Marked as abstract, no implementation is provided here.
    public abstract void click();
}

// Concrete Component
public class Botao : Component
{
    public override void click()
    {
        // Implementation of button click
        Console.WriteLine("A clicar no botão.");
    }
}

public abstract class Decorator : Component
{
    protected Component _component;

    public Decorator(Component component)
    {
        _component = component;
    }

    public override void click()
    {
        _component.click();
    }
}


public class BotaoObservable : Decorator {
    public BotaoObservable(Component component) : base(component){}

    public override void click()
    {
        Console.WriteLine("A observar este clique de botão.");
        base.click();
        
    }
}