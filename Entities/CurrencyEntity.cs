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

  // use code as PK with EF decorator ?
  public Code code { get; set; }
  public string name { get; set; }
}