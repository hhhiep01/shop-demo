using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopdemo.Data.Model;

namespace shopdemo.Configurations
{
    public class CartConfigurations : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasOne(x => x.User).WithOne(x => x.Cart).HasForeignKey<User>(x => x.CartId);
        }
    }
}
