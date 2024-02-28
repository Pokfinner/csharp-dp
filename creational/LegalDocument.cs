namespace creational;

public class LegalDocument : Document
{

    public string contents;
    public bool signed;
    public bool verified;

    public override void Open(){

    }

    public override void Close(){

    }

}

public interface ILegalDocumentBuilder
{
    void CreateDocument();
    void SignDocument();
    void VerifyDocument();
    LegalDocument ShowDocument();
}

public class ExecutiveDocumentBuilder : ILegalDocumentBuilder
{
    public void CreateDocument()
    {
        // get document from executive
    }
    public void SignDocument()
    {
        // sign document by executives
    }
    public void VerifyDocument()
    {
        // verify document by executives
    }
    public LegalDocument ShowDocument()
    {
        // verify document by executives
        return new LegalDocument();
    }
}

public class FinancialDocumentBuilder : ILegalDocumentBuilder
{

    LegalDocument _document;

    // get document from finance
    public void CreateDocument()
    {

        _document = new LegalDocument();

    }
    // sign document by finance
    public void SignDocument()
    {
        _document.signed = true;
    }
    // verify document by finance
    public void VerifyDocument()
    {
        _document.verified = true;
    }
    public LegalDocument ShowDocument()
    {
        return _document;
    }
}

public class LegalDocumentDirector
{
    ILegalDocumentBuilder builder;


    public LegalDocumentDirector(ILegalDocumentBuilder builder)
    {
        this.builder = builder;
    }

    public LegalDocument build()
    {
        builder.CreateDocument();
        builder.SignDocument();
        builder.VerifyDocument();
        return builder.ShowDocument();
    }

}