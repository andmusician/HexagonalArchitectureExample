using HexagonalArchitectureExample3.Business;
using HexagonalArchitectureExample3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArchitectureExample3.Domain
{
    public class OrderController
    {
        private OrderService _orderService;
        private IOrderRepository _orderRepository;

        public OrderController(OrderService orderService, IOrderRepository orderRepository)
        {
            _orderService = orderService;
            _orderRepository = orderRepository;
        }

        public void PlaceOrder(Order order)
        {
            _orderService.PlaceOrder(order);
            _orderRepository.SaveOrder(order);
        }
    }
}
