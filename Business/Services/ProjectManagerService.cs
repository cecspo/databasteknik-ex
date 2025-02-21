﻿using Business.Factories;
using Business.Interfaces;
using Business.Models;
using Data.Interfaces;
using Data.Repositories;
namespace Business.Services;

public class ProjectManagerService(IProjectManagerRepository projectManagerRepository) : IProjectManagerService
{
    private readonly IProjectManagerRepository _projectManagerRepository = projectManagerRepository;

    public async Task<IEnumerable<ProjectManager?>> GetProjectManagerAsync()
    {
        var entities = await _projectManagerRepository.GetAllAsync();
        var projectManagers = entities.Select(ProjectManagerFactory.Create);
        return projectManagers;
    }
}
