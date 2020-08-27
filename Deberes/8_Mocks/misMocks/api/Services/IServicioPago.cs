
namespace Services
{
    public interface IServicioPago
    {
    bool Charge(double total, ITarjeta card);
  }
}