using IG.ClubSystem.Contracts.Repositories;
using IG.ClubSystem.Domain.Entities;

namespace IG.ClubSystem.Persistence.Repositories;

public class MembersRepository(ApplicationDbContext context): Repository<Member>(context), IMembersRepository
{
}
