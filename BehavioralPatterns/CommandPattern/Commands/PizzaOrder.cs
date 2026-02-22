using CommandPattern.Interfaces;
using CommandPattern.Receivers;

namespace CommandPattern.Commands;

public class PizzaOrder : ICommand
{
    private Pizzeria _pizzeria;
    private Order _order;

    public PizzaOrder(Pizzeria pizzeria, Order order)
    {
        _pizzeria = pizzeria;
        _order = order;
    }

    public void Execute()
    {
        _pizzeria.CookPizza(_order.PizzaType);
        _pizzeria.PackPizza();
        _pizzeria.DeliverPizza(_order.Address);
        _pizzeria.Success();
    }

    public bool CanExecute()
    {
        return _pizzeria.CanOrder();
    }
}
