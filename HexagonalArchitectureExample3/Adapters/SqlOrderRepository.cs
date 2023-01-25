using HexagonalArchitectureExample3.Business;
using HexagonalArchitectureExample3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexagonalArchitectureExample3.Adapters
{
    public class SqlOrderRepository : IOrderRepository
    {
        public SqlOrderRepository()
        {

        }
        
        public void SaveOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
