using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThatCSharpGuy.Sample.Services;

namespace OtherNamespace.GoogleChart.Qr
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class GoogleChartQrService : IOnlineQrService
    {
        public string Name => "Google Charts";
        public string GetUrl(string data, int size)
        {
            return $"https://chart.googleapis.com/chart?cht=qr&chs={size}x{size}&chl={data}";
        }
    }
}
