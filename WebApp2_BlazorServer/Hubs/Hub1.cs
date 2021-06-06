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


		//IMGSHARP_STEP2
		//public async Task UploadFile_HUB(InputFileChangeEventArgs e)
		//{
		//	//IMGSHARP_STEP3
		//	await Clients.All.SendAsync("ReceiveFile_HUB", e);
		//}

		//IMGSHARP_STEP2
		public async Task buttonfunction1_send(string e)
		{
			//IMGSHARP_STEP3
			await Clients.All.SendAsync("buttonfunction1_rec", e);
		}
	}
}