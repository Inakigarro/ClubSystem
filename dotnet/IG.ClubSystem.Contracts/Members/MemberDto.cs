namespace IG.ClubSystem.Contracts.Members;

public record MemberDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int MemberId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
