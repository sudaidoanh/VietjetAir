using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietjecAir.Data.Entities;

namespace VietjecAir.Data.Configurations
{
    public class GroupMemberConfiguration : IEntityTypeConfiguration<GroupMember>
    {
        public void Configure(EntityTypeBuilder<GroupMember> builder)
        {
            builder.ToTable("GroupMembers");
            builder.HasKey(x => new {x.UserId, x.GroupId});
            builder.HasOne(x => x.Group).WithMany(x => x.groupMembers).HasForeignKey(x => x.GroupId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.groupMembers).HasForeignKey(x => x.UserId);
        }
    }
}
