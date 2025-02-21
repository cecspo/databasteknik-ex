using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using Data.Repositories;

namespace Business.Services;

public class StatusCodeService(IStatusCodeRepository statusCodeRepository) : IStatusCodeService
{
    private readonly IStatusCodeRepository _statusCodeRepository = statusCodeRepository;

    public async Task<IEnumerable<StatusCode?>> GetStatusCodesAsync()
    {
        var entities = await _statusCodeRepository.GetAllAsync();
        var statusCodes = entities.Select(StatusCodeFactory.Create);
        return statusCodes;
    }
}
