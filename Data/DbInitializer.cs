using System;
using System.Linq;
using Payments.Entities;

namespace Payments.Data
{
  public static class DbInitializer
  {
    public static void Initialize(PaymentContext context)
    {
      context.Database.EnsureCreated();

      // Look for any users.
      if (context.UserRepository.Any())
      {
        return;   // DB has been seeded
      }

      var currencies = new Currency[]
      {
        new Currency{code=Currency.Code.EUR,name="Euro"},
        new Currency{code=Currency.Code.RUB,name="Russian ruble"},
        new Currency{code=Currency.Code.USD,name="United States dollar"},
      };
      foreach (Currency c in currencies)
      {
        context.CurrencyRepository.Add(c);
      }
      context.SaveChanges();

      var users = new User[]
      {
        new User
        {
          firstName="Stark",
          lastName="Anthony",
          currencyID=context.CurrencyRepository.Where(c => c.code == Currency.Code.USD).Single().ID
        },
        new User
        {
          firstName="Romanova",
          lastName="Natasha",
          currencyID=context.CurrencyRepository.Where(c => c.code == Currency.Code.RUB).Single().ID,
        }
      };
      foreach (User u in users)
      {
        context.UserRepository.Add(u);
      }
      context.SaveChanges();

    }
  }
}