namespace creational;

public interface PrototypeDocument
{
    PrototypeDocument Clone();
}

public class PrototypeTextDocument : PrototypeDocument
{
    public Document document { get; set; }

    public PrototypeTextDocument(Document document)
    {
        this.document = document;
    }

    public PrototypeDocument Clone()
    {
        return new PrototypeTextDocument(this.document);
    }
}
