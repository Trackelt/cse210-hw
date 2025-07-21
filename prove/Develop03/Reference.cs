
public class Reference
{
    private List<string> _references;
    public Reference(List<string> references)
    {
        _references = references;
    }

    public List<string> GetRefList()
    {
        return _references;
    }

}