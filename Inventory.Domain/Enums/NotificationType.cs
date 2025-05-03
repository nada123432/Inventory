using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Enums
{
    public enum NotificationType
    {
        LowStock = 0,
        StockMovement = 1, 
        Info = 2,
        Alert = 3
    }
}
