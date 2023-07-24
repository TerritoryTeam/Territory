using Nakama;
using System.Threading.Tasks;

class Cline
{
  const string scheme = "http";
  const string host = "sever.minram.top";
  const int port = 7350;
  const string serverKey = "defaultkey";
  public static async Task Main(string[] args)
  {
        var client = new Client(scheme, host, port, serverKey);
        client.Timeout = 10;

            // var email = "super@heroes.com";
            // var password = "batsignal";
            string deviceID = System.Guid.NewGuid().ToString();
            var session = await client.AuthenticateDeviceAsync(deviceID);
            System.Console.WriteLine("New user: {0}, {1}", session.Created, session);

        for (; ; );
    }
}
