using Microsoft.AspNetCore.Mvc;
using ShoppingApi.Contracts;
using ShoppingApi.Controllers;
using ShoppingApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartTesting
{
    public class ShoppingCartControllerTest
    {
        readonly ShoppingCartController _controller;
        readonly IShoppingCartService _service;

        public ShoppingCartControllerTest()
        {
            _service = new FakeShoppingCart();
            _controller = new ShoppingCartController(_service);
        }

        [Fact]
        public void GetItems_WhenCalled_ReturnsOkResult()
        {
            var result = _controller.GetItems();
            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }

        [Fact]
        public void GetItems_WhenCalled_ReturnsAllItems()
        {
            var result = _controller.GetItems() as OkObjectResult;
            var items = Assert.IsType<List<ShoppingItem>>(result.Value);
            Assert.Equal(3, items.Count);
        }

    }
}
