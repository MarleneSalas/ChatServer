using Microsoft.AspNetCore.SignalR.Client;

namespace ChatClient
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            string url = "https://chat_itesrc.net/chat";
            var _connection = new HubConnectionBuilder().WithUrl(url).WithAutomaticReconnect().Build();

            _connection.On<string>
        }
    }
}
