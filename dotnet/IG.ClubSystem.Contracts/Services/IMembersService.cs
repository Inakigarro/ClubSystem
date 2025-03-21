using IG.ClubSystem.Contracts.Members;

namespace IG.ClubSystem.Contracts.Services;

public interface IMembersService
{
    Task<MemberDto> AddAsync(CreateMemberDto member, CancellationToken cancellationToken);
}
