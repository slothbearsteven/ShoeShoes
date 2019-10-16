using System;
using System.Collections.Generic;
using ShoeStore.Models;
using ShoeStore.Repositories;

namespace ShoeStore.Services
{
    public class OrdersService
    {
        private readonly OrdersRepository _repo;
        private readonly ShoesRepository _shoeRepo;
        public OrdersService(OrdersRepository repo, ShoesRepository shoeRepo)
        {
            _shoeRepo = shoeRepo;
            _repo = repo;
        }

        public IEnumerable<Order> Get()
        {
            return _repo.Get();
        }

        public Order Get(int id)
        {
            Order exists = _repo.Get(id);
            if (exists == null) { throw new Exception("Invalid Id Homie"); }
            return exists;
        }

        public Order Create(Order newOrder)
        {
            int id = _repo.Create(newOrder);
            newOrder.Id = id;
            return newOrder;
        }

        public Order Edit(Order newData)
        {
            Order order = _repo.Get(newData.Id);
            if (order == null) { throw new Exception("Invalid Id Homie"); }
            order.CustomerName = newData.CustomerName;
            _repo.Edit(order);
            return order;
        }

        public string Delete(int id)
        {
            Order order = _repo.Get(id);
            if (order == null) { throw new Exception("Invalid Id Homie"); }
            _repo.Delete(id);
            return "Successfully Booted";
        }


        //SECTION SHOE ORDERS
        public Order AddShoe(int id, Shoe shoe)
        {
            Order order = _repo.Get(id);
            if (order == null) { throw new Exception("Invalid Id Homie"); }
            Shoe shoeToAdd = _shoeRepo.Get(shoe.Id);
            if (shoeToAdd == null) { throw new Exception("Invalid Id Homie"); }
            _repo.AddShoe(id, shoe.Id);
        }
    }
}