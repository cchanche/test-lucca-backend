namespace Payments.Entities;
public record Currency
{

  // enums are ints
  // -> store supported currencies as strings ?
  public enum Code
  {
    USD, EUR, RUB
  }

  public int ID { get; set; } // PK

  public string code { get; set; }
  public string name { get; set; }
}