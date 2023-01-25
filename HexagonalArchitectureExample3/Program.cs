using HexagonalArchitectureExample3.Adapters;
using HexagonalArchitectureExample3.Business;
using HexagonalArchitectureExample3.Domain;
using HexagonalArchitectureExample3.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        OrderService orderService = new OrderService();        
        IOrderRepository orderRepository = new SqlOrderRepository();
        OrderController orderController = new OrderController(orderService, orderRepository);
    }
}