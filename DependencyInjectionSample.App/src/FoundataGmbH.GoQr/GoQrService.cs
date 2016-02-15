using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThatCSharpGuy.Sample.Services;

namespace FoundataGmbH.GoQr
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class GoQrService : IOnlineQrService
    {
        public GoQrService()
        {
        }

        public string Name { get; } = "Go QR";
        public string GetUrl(string data, int size)
        {
            return $"https://api.qrserver.com/v1/create-qr-code/?size={size}x{size}&data={data}";
        }
    }
}
