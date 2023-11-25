using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using shopdemo.Data.Model;

namespace shopdemo.Configurations
{
    public class CartItemConfigurations : IEntityTypeConfiguration<Cart_Item>
    {
        public void Configure(EntityTypeBuilder<Cart_Item> builder)
        {
            builder.HasOne(x => x.Cart).WithMany(x => x.Cart_Items).HasForeignKey(x => x.CartId);

            builder.HasOne(x => x.Item).WithMany(x => x.Cart_Items).HasForeignKey(x => x.ItemId);

        }
    }
}
