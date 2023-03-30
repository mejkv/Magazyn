using MagazynEdu.ApplicationsServices.API.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagazynEdu.Controllers;

[ApiController]
[Route("(controller)")]
public class DevicesController : ControllerBase
{
    private readonly IMediator mediator;

    public DevicesController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    [Route("")]
    public async Task<IActionResult> GetAllDevices([FromQuery] GetDevicesRequest request)
    {
        var response = await this.mediator.Send(request);
        return this.Ok(response);
    }
}

