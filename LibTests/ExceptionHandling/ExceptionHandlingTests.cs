using System.Net.Sockets;

namespace LibTests.ExceptionHandling;

[TestClass]
public class ExceptionHandlingTests
{
    [TestMethod]
    public void HandleIOTestAsync()
    {
        using var client = new TcpClient();
        try
        {
            client.Connect("www.example.com", 80);
        }
        catch (Exception ex)
        {
            throw new Exception("Connection Error: " + ex.Message);
        }
        finally
        {
            client.Dispose();
        }
    }
}
