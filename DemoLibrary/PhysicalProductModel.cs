using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class PhysicalProductModel : PhysicalProductBase, IProductModel
    {
        public bool HasOrderBeenCompleted { get; private set; }
        public string Title { get; set; }

        public void ShipItem(CustomerModel customer)
        {
            Console.WriteLine($"Simulating shipping { Title } to {  customer.FirstName } in { customer.City }");
            HasOrderBeenCompleted = true;
        }
    }
}
