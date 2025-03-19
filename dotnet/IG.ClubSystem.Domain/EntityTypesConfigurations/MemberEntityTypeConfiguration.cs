using IG.ClubSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IG.ClubSystem.Domain.EntityTypesConfigurations;

public class MemberEntityTypeConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.MemberId)
            .ValueGeneratedOnAdd();
        builder.Property(x => x.Name)
            .HasMaxLength(100);
        builder.Property(x => x.Email)
            .HasMaxLength(100);
    }
}
