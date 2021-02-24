using System;
using ServiceStack;
using WebTemplate.ServiceModel;

namespace WebTemplate.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
