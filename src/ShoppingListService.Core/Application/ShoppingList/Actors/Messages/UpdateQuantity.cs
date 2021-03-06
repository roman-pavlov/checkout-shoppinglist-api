﻿namespace ShoppingListService.Core.Application.ShoppingList.Actors.Messages
{
    public sealed class UpdateQuantity : ShoppingListMessage
    {
        public UpdateQuantity(string customerId, string name, int quantity)
            : base(customerId)
        {
            Name = name;
            Quantity = quantity;
        }

        public string Name { get; }

        public int Quantity { get; }
    }
}