namespace ServiceInjectionNet8;

public class NewWrapper(INewService service)
{
    public string GetNewData() => service.GetData();
}