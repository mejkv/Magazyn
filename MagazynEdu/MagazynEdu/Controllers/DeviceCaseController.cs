using MagazynEdu.DataAccess;
using MagazynEdu.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MagazynEdu.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceCaseController : ControllerBase
    {
        private readonly IRepository<DeviceCase> deviceCaseRepository;

        public DeviceCaseController(IRepository<DeviceCase> deviceCaseRepository) 
        {
            this.deviceCaseRepository = deviceCaseRepository;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<DeviceCase> GetAllDevices() => this.deviceCaseRepository.GetAll();
    }
}