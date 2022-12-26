using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    internal class Orders
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public int Quantity { get; set; }

        public decimal Cost { get; set; }

        public virtual Customers Customer { get; set; }

        public virtual Products Product { get; set; } 

    }
}
