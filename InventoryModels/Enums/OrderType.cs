using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels.Enums
{
    public enum OrderType
    {
        PurchaseOrder,
        CustomerOrder
    }

    public enum OrderStatus
    {
        CheckOut,
        Paid,
        Failed,
        Shipped,
        Delivered,
        Returned,
        Completed
    }
}
