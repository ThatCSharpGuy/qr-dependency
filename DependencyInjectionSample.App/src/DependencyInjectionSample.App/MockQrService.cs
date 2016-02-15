using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThatCSharpGuy.Sample.Services;

namespace DependencyInjectionSample.App
{
    public class MockQrService : IOnlineQrService
    {
        public string Name => "Mock";
        public string GetUrl(string data, int size)
        {
            // ignore all
            return @"\img\technical.jpg";
        }
    }
}
