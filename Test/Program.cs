using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Celin
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var e1 = new AIS.Server("https://demo.steltix.com/jderest/v2/");
            e1.AuthRequest.username = "demo";
            e1.AuthRequest.password = "demo";

            var f = await e1.RequestAsync<W060116C.Response>(new W060116C.Request("7701"));
            var s = JsonSerializer.Serialize(f.fs_P060116_W060116C.data, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            Console.WriteLine(s);
        }
    }
}
