using System.Net;
using System.Net.Sockets;
using System.Text;

var ipEndPoint = new IPEndPoint(IPAddress.Any, 5000);
TcpListener listener = new(ipEndPoint);

static void Shutdown(TcpListener listener)
{
    Console.WriteLine("Shutting down...");
    listener.Stop();
}

try
{
    listener.Start();
    Console.WriteLine("Listening on port 5000...");

    Console.CancelKeyPress += delegate
    {
        Shutdown(listener);
    };

    while (true)
    {
        using TcpClient handler = await listener.AcceptTcpClientAsync();
        await using NetworkStream stream = handler.GetStream();

        var message = $"📅 {DateTime.Now} 🕛";
        var dateTimeBytes = Encoding.UTF8.GetBytes(message);

        var headers = new StringBuilder()
            .Append("HTTP/1.1 200 OK\r\n")
            .Append($"Content-Length: {dateTimeBytes.Length}\r\n")
            .Append("Content-Type: text/plain; charset=utf-8\r\n")
            .Append("Connection: close\r\n")
            .Append("\r\n")
            .ToString();

        var response = Encoding.ASCII
            .GetBytes(headers)
            .Concat(dateTimeBytes)
            .ToArray();

        await stream.WriteAsync(response);

        Console.WriteLine($"Sent message: \"{message}\"");
    }
}
finally
{
    Shutdown(listener);
}
