using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThatCSharpGuy.Sample.Services
{
    public class DemoQrService : IOnlineQrService
    {
        public string Name => "Demo";
        public string GetUrl(string data, int size)
        {
            return $"http://placehold.it/{size}?text={data}";
        }
    }
}
