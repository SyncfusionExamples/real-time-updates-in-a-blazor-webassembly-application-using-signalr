using Microsoft.AspNetCore.Mvc;
using BlazorSignalRScheduler.Shared;

namespace BlazorSignalRScheduler.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppointmentDataController : ControllerBase
    {


        [HttpGet]
        public List<AppointmentData> Get()
        {
            List<AppointmentData> DataSource = new List<AppointmentData>
            {
                new AppointmentData{ Id = 1, Subject = "Meeting", StartTime = new DateTime(2023, 5, 11, 9, 30, 0) , EndTime = new DateTime(2023, 5, 11, 11, 0, 0)} 
            };
            return DataSource;
        }
    }
}
