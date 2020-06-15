using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class OrdersController : ControllerBase
  {
    [HttpGet("{id}")]
    public IEnumerable<OrderModel> Get(int id)
    {
      return new List<OrderModel>() {
        new OrderModel() { OrderId = 1, OrderAmount = 250, OrderData = DateTime.Now.AddDays(-2) },
        new OrderModel() { OrderId = 2, OrderAmount = 450, OrderData = DateTime.Now.AddDays(-1) }
      };

    }
  }
}
