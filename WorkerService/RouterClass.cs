using Nancy;

namespace WorkerService
{
    public class RouterClass : NancyModule
    {
        public RouterClass()
        {
            Get("/", response => "Hurray !");
        }
    }
}