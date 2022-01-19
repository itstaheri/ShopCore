using System;

namespace IM.Domain.Inventory
{
    public class InventoryOperationModel
    {
        protected InventoryOperationModel()
        {

        }
        public InventoryOperationModel(bool operation, long count, long operatorId, long currentCount
            , string description, long orderId, long inventoryId)
        {
            Operation = operation;
            Count = count;
            OperatorId = operatorId;
            CurrentCount = currentCount;
            Description = description;
            OrderId = orderId;
            InventoryId = inventoryId;
            OperationDate = DateTime.Now;
        }
        public void ReduceAfterPay(int count)
        {
            CurrentCount =CurrentCount - count;
        }
        public long Id { get; private set; }
        //vared ya kharej shode
        public bool Operation { get; private set; }
        //che tedad vared ya kharej shode
        public long Count { get; private set; }
        //Id Karbar
        public long OperatorId { get; private set; }
        //zaman amaliat
        public DateTime OperationDate { get; private set; }
        //Mojoodi anbar dar tarikh amaliat cheghadr boode
        public long CurrentCount { get; private set; }
        //tozihat
        public string Description { get; private set; }
        //shomare sefaresh
        public long OrderId { get; private set; }
        //baraye fahmidan inke operation marboot be kodoom anbar bude
        public long  InventoryId { get; private set; }
        public InventoryModel inventoryModel { get;private set; }
    }
}
