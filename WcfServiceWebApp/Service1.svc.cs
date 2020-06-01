namespace WcfServiceWebApp
{
    public class Service1 : IService1
    {
        public string Hello(string name)
        {
            return string.Format($"Hello {name} from {System.Net.Dns.GetHostName()}!");
        }
    }
}
