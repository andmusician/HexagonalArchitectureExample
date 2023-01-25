using HexagonalArchitectureExample3.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArchitectureExample3.Interfaces
{
    public interface IOrderRepository
    {
        void SaveOrder(Order order);
    }
}
