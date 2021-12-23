﻿

namespace IM.Application.Contract.Inventory
{
    public class InventoryViewModel
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long ProductId { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public long CurrentCount { get; set; }
    }
}
   
