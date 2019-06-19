using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

public static class Program
{
    public static void Main(string[] args)
    {
        IHttpServer server = new HttpServer();
        server.start();
    }

}
public interface IHttpServer
{
    void start();
    void stop();
}
public class HttpServer:IHttpServer
{
    private bool isWorking;
    private TcpListener tcpListener;
    public HttpServer()
    {
        this.tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
    }
    public void start()
    {
        this.isWorking = true;
        this.tcpListener.Start();
        while (this.isWorking)
        {
            var client = this.tcpListener.AcceptTcpClient();
            var buffer = new byte[10240];
            var stream = client.GetStream();
            var readLength = stream.Read(buffer, 0, buffer.Length);
            var requestText = Encoding.UTF8.GetString(buffer,0,readLength);
            Console.WriteLine(new string('=',60));
            Console.WriteLine(requestText);
            var responseText = File.ReadAllText("index.html");
            var response = Encoding.UTF8.GetBytes("HTTP/1.0 200 OK" + Environment.NewLine + "Content-Type: text/html" + Environment.NewLine +"Content-Length: " + responseText.Length +
                Environment.NewLine + Environment.NewLine + responseText);
            stream.Write(response,0,response.Length);
        }
    }

    public void stop()
    {
        this.isWorking = false;
    }
}

