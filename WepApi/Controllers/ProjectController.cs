using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectController(IProjectService projectService) : ControllerBase
{
    private readonly IProjectService _projectService = projectService;

    [HttpGet("{id}")]

    public async Task<IActionResult> GetProjects(int id)
    {
        var project = await _projectService.GetProjectAsync(id);
        return project == null ? NotFound() : Ok(project);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProject(Project project)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

    }
}
