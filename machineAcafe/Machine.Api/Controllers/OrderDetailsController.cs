﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Machine.Data.Repo;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Machine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrder order;
        private readonly IOrderDetail orderDetail;

        public OrderDetailsController(IOrder order, IOrderDetail orderDetail)
        {
            this.order = order;
            this.orderDetail = orderDetail;
        }
        // GET: api/<OrderDetailsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrderDetailsController>/5
        [HttpGet("{serial}")]
        public string Get(int serial)
        {
            
            return "value";
        }

        // POST api/<OrderDetailsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrderDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
