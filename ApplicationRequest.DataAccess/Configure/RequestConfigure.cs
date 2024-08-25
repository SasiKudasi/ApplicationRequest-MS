using ApplicationRequest.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ApplicationRequest.DataAccess.Configure
{
    public class RequestConfigure : IEntityTypeConfiguration<RequestEntity>
    {
        public void Configure(EntityTypeBuilder<RequestEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.AnimalId).IsRequired();
            builder.Property(e => e.Status).IsRequired().HasMaxLength(100);
            builder.Property(e => e.CreatedAt).IsRequired();
            builder.Property(e => e.LastUpdatedAt).IsRequired();
        }
    }
}
