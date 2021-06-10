using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Server.Hubs
{
    public class Hub1 : Hub
	{
		//CHATHUB_STEP2
		public async Task SendMessage1(string user, string message)
		{
			//CHATHUB_STEP3
			await Clients.All.SendAsync("ReceiveMessage2", user, message);
		}

		//BUTTON1_STEP2
		public async Task Edge_signalr1(int i)
		{
			//BUTON1_STEP3
			await Clients.All.SendAsync("Edge_signalr2", i);
		}

		////IMGSHARP_STEP2
		public async Task UploadFile_1(InputFileChangeEventArgs e)
		{
			////IMGSHARP_STEP3
			await Clients.All.SendAsync("UploadFile_2", e);
		}


	}
}