namespace creational;

public class DocumentEditor
{

    private static DocumentEditor _instance;


    public static DocumentEditor Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new DocumentEditor();
            }
            return _instance;
        }
    }

}