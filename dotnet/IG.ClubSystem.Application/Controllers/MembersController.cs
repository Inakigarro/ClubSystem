using IG.ClubSystem.Contracts.Members;
using IG.ClubSystem.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace IG.ClubSystem.Application.Controllers;

[ApiController]
[Route("[controller]")]
public class MembersController(
    ILogger<MembersController> logger,
    IMembersService service): ControllerBase
{
    [HttpPost]
    [Route("CreateMember")]
    public async Task<IActionResult> CreateMember(CreateMemberDto createMember, CancellationToken cancellationToken = default)
    {
        try
        {
            logger.LogInformation("MembersController - Creating a new member with data: {createMember}", createMember);
            var createdMember = await service.AddAsync(createMember, cancellationToken);
            logger.LogInformation("MembersController - Member created with data: {createMember}", createMember);
            return Ok(createdMember);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
