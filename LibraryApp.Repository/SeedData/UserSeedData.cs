using LibraryApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repository.SeedData
{
    public class UserSeedData : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData(
                    new Users() { Id = 1, FirstName = "Sefa", LastName = "Attila", Email = "attila@gmail.com", Password = "123456" },
                    new Users() { Id = 2, FirstName = "Ali", LastName = "Yaşar", Email = "ali@gmail.com", Password = "54546546" },
                    new Users() { Id = 3, FirstName = "Mehmet", LastName = "Gündüz", Email = "mehmet@gmail.com", Password = "873687" },
                    new Users() { Id = 4, FirstName = "Mahmut", LastName = "Gece", Email = "mahmut@gmail.com", Password = "981376" }
                );
        }
    }
}
