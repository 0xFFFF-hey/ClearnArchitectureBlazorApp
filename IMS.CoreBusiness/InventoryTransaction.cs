using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness
{
    public class InventoryTransaction
    {
        public int InventoryTransactionId { get; set; }
        public int InventoryId { get; set; }
        public int Quantity { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }

        // Business logic methods
        public bool IsPurchase() => TransactionType == TransactionType.PurchaseInventory;
        public bool IsConsume() => TransactionType == TransactionType.ConsumeInventory;
    }
}
