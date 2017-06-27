using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;


namespace Сongratulation.Models
{
  public class SampleData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      var context = serviceProvider.GetService<CongratulationContext>();

      if (!context.СongratulateUsers.Any())
      {
        context.СongratulateUsers.AddRange(
            new СongratulateUser
            {
              Alias = "Ivanov",
              Name = "Ivanov",
              Surname = "Apple",
              BirthdayDate = DateTime.Parse("10.01.1980")
            },
            new СongratulateUser
            {
              Alias = "Petrov",
              Name = "Petrov",
              Surname = "Apple",
              BirthdayDate = DateTime.Parse("10.01.1980")
            },
            new СongratulateUser
            {
              Alias = "Sidorov",
              Name = "Sidorov",
              Surname = "Apple",
              BirthdayDate = DateTime.Parse("10.01.1980")
            }
        );
        context.SaveChanges();
      }
    }
  }
}
