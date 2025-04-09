using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WinPG.Models
{
    public class PGVPN
    {
        readonly HttpClient client = new HttpClient(new SocketsHttpHandler()
        {
            ConnectCallback = (context, cancellationToken) =>
            {
                string userHomeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string socketFilePath = System.IO.Path.Combine(userHomeDirectory, ".pgvpn.sock");
                var socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);
                socket.Connect(new UnixDomainSocketEndPoint(socketFilePath));
                return new ValueTask<Stream>(new NetworkStream(socket, ownsSocket: true));
            }
        });

        public async Task<Peer[]?> QueryPeers() // Fixed return type to Task<Peer[]?>
        {
            try
            {
                var resp = await client.GetFromJsonAsync<QueryPeersResponse>("http://ipc/apis/p2p/v1alpha1/peers");
                return resp?.Data ?? [];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return [];
            }
        }
    }

    public class QueryPeersResponse
    {
        public int Code { get; set; }
        public Peer[]? Data { get; set; }
        public string? Msg { get; set; }
    }

    public class Peer
    {
        public string? ID { get; set; }
        public string? Hostname { get; set; }
        public string? IPv4 { get; set; }
        public string? IPv6 { get; set; }
        public string[]? Addrs { get; set; } = Array.Empty<string>(); // Simplified initialization to fix IDE0301
        public DateTime LastActiveTime { get; set; }
        public string? Mode { get; set; }
        public string? NAT { get; set; }
        public string? Version { get; set; }
        public string[]? Labels { get; set; } = Array.Empty<string>(); // Simplified initialization to fix IDE0301
    }
}
