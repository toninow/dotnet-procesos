namespace Services 
{
  public interface IDireccion
  {
    public string Street { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string PhoneNumber { get; set; }
  }

  public interface ITarjeta 
  {
    public string CardNumber { get; set; }
    public string Name { get; set; }

  }

  public interface ItemsTarjeta 
  {
    public string ProductId { get; set; }
    public int Quantity { get; set; }
    public double Price{ get; set; }
  }
}
