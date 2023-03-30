using MagazynEdu.ApplicationsServices.API.Domain;
using MagazynEdu.DataAccess;
using MediatR;

namespace MagazynEdu.ApplicationsServices.API.Handlers
{
    public class GetDevicesHandler : IRequestHandler<GetDevicesRequest, GetDevicesResponse>
    {
        private readonly IRepository<DataAccess.Entities.Device> deviceRepository;

        public GetDevicesHandler(IRepository<DataAccess.Entities.Device> deviceRepository)
        {
            this.deviceRepository = deviceRepository;
        }

        public Task<GetDevicesResponse> Handle(GetDevicesRequest request, CancellationToken cancellationToken)
        {
            var devices = this.deviceRepository.GetAll();
            var domainDevices = devices.Select(x => new Domain.Models.Device()
            {
                Id = x.Id,
                Title = x.Title,
            });

            var response = new GetDevicesResponse() 
            {
                Data = domainDevices.ToList()
            };
            return Task.FromResult(response);
        }
    }
}
