using Microsoft.AspNetCore.SignalR.Client;

namespace ChatClient
{
    public partial class MainPage : ContentPage
    {
        private HubConnection _connection;

        public MainPage()
        {
            string url = "https://chat_itesrc.net/chat";
            _connection = new HubConnectionBuilder().WithUrl(url).WithAutomaticReconnect().Build();

            _connection.On<string>("ReceiveMessage", message =>
            {
                lblHistory.Text += $"(message)<br/>";
            });
        }

        private async void btnSend_Clicked(object sender, EventArgs e)
        {
            object a = txtMessage.Text;
            await _connection.InvokeAsync("SendMessage", a);
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            _connection.StartAsync();
        }
    }
}
