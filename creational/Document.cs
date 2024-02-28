namespace creational;

//Product
public abstract class Document{
    public abstract void Open();
    public abstract void Close();
}

//Concrete Products
public class TextDocument : Document{
    public override void Open()
    {
        // implementation
    }
    public override void Close()
    {
        // implementation
    }
}

public class SheetDocument : Document{
    public override void Open()
    {
        // implementation
    }
    public override void Close()
    {
        // implementation
    }
}

// Creator
public abstract class DocumentCreator{
    public abstract Document CreateDocument();
}

// Concrete Creators
public class TextDocumentCreator : DocumentCreator{
    public override Document CreateDocument()
    {
        return new TextDocument();
    }
}

public class SheetDocumentCreator : DocumentCreator{
    public override Document CreateDocument()
    {
        return new SheetDocument();
    }
}
