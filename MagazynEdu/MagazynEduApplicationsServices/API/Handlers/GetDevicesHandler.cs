using AutoMapper;
using MagazynEdu.ApplicationsServices.API.Domain;
using MagazynEdu.DataAccess;
using MediatR;

namespace MagazynEdu.ApplicationsServices.API.Handlers
{
    public class GetDevicesHandler : IRequestHandler<GetDevicesRequest, GetDevicesResponse>
    {
        private readonly IRepository<DataAccess.Entities.Device> deviceRepository;
        private readonly IMapper mapper;

        public GetDevicesHandler(IRepository<DataAccess.Entities.Device> deviceRepository, IMapper mapper)
        {
            this.deviceRepository = deviceRepository;
            this.mapper = mapper;
        }

        public async Task<GetDevicesResponse> Handle(GetDevicesRequest request, CancellationToken cancellationToken)
        {
            var devices = await this.deviceRepository.GetAll();
            var mappedDevice = this.mapper.Map<List<Domain.Models.Device>>(devices);
            var response = new GetDevicesResponse() 
            {
                Data = mappedDevice
            };
            return response;
        }
    }
}
