namespace Payments.Entities;
public record Payment
{

  public enum PaymentTarget
  {
    Restaurant, Hotel, Misc
  }

  public int ID { get; set; } // PK
  // EF interprets a property as a FK property if it's named <navigation property name><primary key property name>
  public int userID { get; set; } // FK
  public int currencyID { get; set; }

  public DateTime date { get; set; }
  public PaymentTarget target { get; set; }
  public decimal amount { get; set; }
  public string comment { get; set; }

  public User user { get; set; }
  public Currency currency { get; set; }

}