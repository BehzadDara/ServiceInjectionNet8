namespace ServiceInjectionNet8;

public class BigWrapper([FromKeyedServices("big")] IService service)
{
    public string GetBigData() => service.GetData();
}
