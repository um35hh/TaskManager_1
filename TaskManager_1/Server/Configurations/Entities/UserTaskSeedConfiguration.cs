using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager_1.Shared.Domain;

namespace TaskManager_1.Server.Configurations.Entities
{
    public class UserTaskSeedConfiguration : IEntityTypeConfiguration<UserTask>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserTask> builder)
        {
            builder.HasData(
new UserTask
{
    Id = 1,
    TaskName = "task1",
    IsCompleted = true,
    CreatedDate = DateTime.Now,
    DueDate= DateTime.Now,
    CreatedBy = "System"
    
},
new UserTask
{
    Id = 2,
    TaskName = "task2",
    IsCompleted = false,
    CreatedDate = DateTime.Now,
    DueDate = DateTime.Now,
    CreatedBy = "System"
}
);
           






           // throw new NotImplementedException();
        }
    }
}
