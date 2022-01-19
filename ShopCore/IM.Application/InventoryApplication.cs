using Frameworks;
using IM.Application.Contract.Inventory;
using IM.Domain.Inventory;
using System;
using System.Collections.Generic;

namespace IM.Application
{
    public class InventoryApplication : IInventoryApplication
    {
        private readonly IInventoryRepository _repository;
        private readonly IAuthHelper _authHelper;
        public InventoryApplication(IInventoryRepository repository, IAuthHelper authHelper)
        {
            _repository = repository;
            _authHelper = authHelper;
        }

        public void Create(CreateInventory commend)
        {

            var inventory = new InventoryModel(commend.Productid, commend.Price);
            _repository.Create(inventory);

        }

        public void Edit(EditInventory commend)
        {
            var inventory = _repository.GetDetails(commend.Id);
            inventory.Edit(commend.Productid, commend.Price,inventory.InStock);
            _repository.Save();
        }

        public List<InventoryViewModel> GetAll(SearchInventory commend)
        {
            return _repository.search(commend);
        }

        public List<InventoryOperationViewModel> GetforLogss(long InventoryId)
        {
            return _repository.GetForLoggs(InventoryId);
        }

        public EditInventory GetValueForEdit(long Id)
        {
            var value = _repository.GetDetails(Id);
            return new EditInventory
            {
                Id = value.Id,
                Price = value.Price,
                Productid = value.Productid
            };
        }

        public void Increase(IncreaseInventory commend)
        {
            var operatorId = _authHelper.CurrentAccountId();
            var inventory = _repository.GetDetails(commend.InventoryId);
            inventory.Increase(commend.Count, operatorId, commend.Description);
            _repository.Save();
        }

        public void Reduce(ReduceInventory commend)
        {
            var operatorId = _authHelper.CurrentAccountId();
            var inventory = _repository.GetDetails(commend.InventoryId);
            inventory.Reduce(commend.Count, operatorId, commend.Description, 0);
            _repository.Save();

        }

        public void ReduceList(List<ReduceInventory> commend)
        {
            var operatorId = _authHelper.CurrentAccountId();
            foreach (var item in commend)
            {
                var inventory = _repository.GetBy(item.ProductId);
                inventory.Reduce(item.Count, operatorId, item.Description, item.OrderId);
                
            }
            _repository.Save();
        }

        public void Save()
        {
            _repository.Save();
        }
    }
}
