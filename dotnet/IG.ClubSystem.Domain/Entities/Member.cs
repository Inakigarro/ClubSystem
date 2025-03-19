namespace IG.ClubSystem.Domain.Entities;

public class Member: IId
{
    public Guid Id { get; set; }
    public int MemberId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
