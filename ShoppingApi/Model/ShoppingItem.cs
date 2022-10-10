﻿namespace ShoppingApi.Model
{
    public class ShoppingItem
    {
        public int ShoppingItemId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Manufacturer { get; set; }
    }
}
