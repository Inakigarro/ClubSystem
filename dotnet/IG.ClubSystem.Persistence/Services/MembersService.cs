using IG.ClubSystem.Contracts.Members;
using IG.ClubSystem.Contracts.Repositories;
using IG.ClubSystem.Contracts.Services;
using IG.ClubSystem.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace IG.ClubSystem.Persistence.Services;

public class MembersService(
	Logger<MembersService> logger,
	IMembersRepository repository): IMembersService
{
    public async Task<MemberDto> AddAsync(CreateMemberDto member, CancellationToken cancellationToken)
    {
		try
		{
			logger.LogInformation("MembersService - Creating a new member with data: {member}", member);

			Member newMember = new()
			{
				Name = member.Name,
				Email = member.Email,
			};

			// Save the member in the context.
			await repository.AddAsync(newMember, cancellationToken);
			await repository.SaveAsync(cancellationToken);

			// Get the member fully populated.
			var memberCreated = await repository.GetAsync(newMember.Id, cancellationToken);

            logger.LogInformation("MembersService - Member created with data: {member}", memberCreated);
            return new()
			{
				Id = memberCreated.Id,
				MemberId = memberCreated.MemberId,
				Name = memberCreated.Name,
				Email = memberCreated.Email,
			};
		}
		catch (Exception e)
		{
			logger.LogError("MemberService - An error occured while creating a member: {messasge}", e.Message);
			throw;
		}
    }
}
