namespace ServiceInjectionNet8;

public class SmallWrapper([FromKeyedServices("small")] IService service)
{
    public string GetSmallData() => service.GetData();
}
