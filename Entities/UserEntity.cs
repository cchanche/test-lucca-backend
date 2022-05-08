namespace Payments.Entities;

public record User
{
  // EF interprets a property that's named ID or classnameID as the primary key
  public int ID { get; set; }
  public int currencyID { get; set; }

  public string firstName { get; set; }
  public string lastName { get; set; }

  public ICollection<Payment> Payments { get; set; }
  public Currency currency { get; set; }
}
