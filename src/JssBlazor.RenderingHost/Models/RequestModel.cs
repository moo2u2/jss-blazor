namespace JssBlazor.RenderingHost.Models
{
    public class RequestModel
    {
        public string Id { get; set; }
        public object Args { get; set; }
        public string FunctionName { get; set; }
        public string ModuleName { get; set; }
    }
}
