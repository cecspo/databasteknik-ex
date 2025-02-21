using Business.Factories;
using Business.Models;
using Data.Interfaces;

namespace Business.Services;

public class ProjectService(IProjectRepository projectRepository, ICustomerRepository customerRepository)
{
    private readonly IProjectRepository _projectRepository = projectRepository;
    private readonly ICustomerRepository _customerRepository = customerRepository;

    public async Task<bool> CreateProjectAsync(ProjectRegistrationForm form)
    {
        if (!await _customerRepository.AlreadyExistsAsync(customer => customer.Id == form.CustomerNumber))
            return false;

        var projectEntity = ProjectFactory.Create(form);
        if (projectEntity == null)
            return false;

        bool result = await _projectRepository.AddAsync(projectEntity)
            return result;
    }

    public async Task<bool> GetAsync()
    {

    }

    public async Task<IEnumerable<> GetAllAsync()
    {

    }

    public async Task<bool> UpdateAsync()
    {

    }

    public async Task<bool> RemoveAsync()
    {

    }
}
