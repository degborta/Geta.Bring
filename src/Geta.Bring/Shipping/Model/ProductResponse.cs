﻿namespace Geta.Bring.Shipping.Model
{
    internal class ProductResponse
    {
        public ProductResponse(
            string productId, 
            string productCodeInProductionSystem, 
            GuiInformation guiInformation, 
            PackagePrice price, 
            ExpectedDelivery expectedDelivery)
        {
            ExpectedDelivery = expectedDelivery;
            Price = price;
            GuiInformation = guiInformation;
            ProductCodeInProductionSystem = productCodeInProductionSystem;
            ProductId = productId;
        }

        public string ProductId { get; private set; }
        public string ProductCodeInProductionSystem { get; private set; }
        public GuiInformation GuiInformation { get; private set; }
        public PackagePrice Price { get; private set; }
        public ExpectedDelivery ExpectedDelivery { get; private set; }
    }
}