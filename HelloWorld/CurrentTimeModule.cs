using System;
using Nancy;

namespace HelloWorld
{
    public class CurrentTimeModule : NancyModule
    {
        public CurrentTimeModule()
        {
            Get("/", _ => DateTime.UtcNow);
        }
    }
}
