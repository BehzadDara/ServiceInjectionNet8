namespace ServiceInjectionNet8;

public class OldWrapper
{
    private readonly IOldService service;
    public OldWrapper(IOldService service)
    {
        this.service = service;
    }

    public string GetOldData() => service.GetData();
}