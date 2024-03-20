using IceTaskOne_CLVDA.Data;
using IceTaskOne_CLVDA.Models.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace IceTaskOne_CLVDA.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new IceTaskOne_CLVDAContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<IceTaskOne_CLVDAContext>>()))
            {
                // Look for any movies.
                if (context.Tasks.Any())
                {
                    return;   // DB has been seeded
                }
                context.Tasks.AddRange(
                    new Tasks.Tasks
                    {
                        taskName = "Do Database",
                        taskState = "To Do",
                        taskGiver = "Loren",
                        TaskDueDate = DateTime.Parse("2024-2-12"),
                    },
                    new Tasks.Tasks
                    {
                        taskName = "Do Front-end",
                        taskState = "Doing",
                        taskGiver = "Mikey",
                        TaskDueDate = DateTime.Parse("2024-3-24"),
                    },
                    new Tasks.Tasks
                    {
                        taskName = "Do Programming",
                        taskState = "Done",
                        taskGiver = "Tom",
                        TaskDueDate = DateTime.Parse("2023-12-2"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
