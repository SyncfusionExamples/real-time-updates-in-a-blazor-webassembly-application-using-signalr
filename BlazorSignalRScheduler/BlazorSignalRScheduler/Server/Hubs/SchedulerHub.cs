using BlazorSignalRScheduler.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRScheduler.Server.Hubs
{
    public class SchedulerHub : Hub
    {
        public async Task SendData(string user, List<AppointmentData> addedData, List<AppointmentData> changedData, List<AppointmentData> deletedData)
        {
            await Clients.Others.SendAsync("ReceiveData", user, addedData, changedData, deletedData);
        }
    }
}
