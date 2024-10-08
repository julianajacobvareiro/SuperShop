﻿using SuperShop.Data.Entities;
using SuperShop.Models;
using System;
using System.IO;

namespace SuperShop.Helpers
{
	public class ConverterHelper : IConverterHelper
	{
		public Product ToProduct(ProductViewModel model, Guid imageId, bool isNew)
		{
			return new Product
			{
				Id = isNew ? 0 : model.Id,
				ImageId = imageId,
				IsAvailable = model.IsAvailable,
				LastPurchase = model.LastPurchase,
				LastSale = model.LastSale,
				Name = model.Name,
				Price = model.Price,
				StockPrice = model.StockPrice,
				User = model.User
			};
		}

		public ProductViewModel ToProductViewModel(Product product)
		{
			return new ProductViewModel
			{
				Id = product.Id,
				IsAvailable = product.IsAvailable,
				LastPurchase = product.LastPurchase,
				LastSale = product.LastSale,
				ImageId = product.ImageId,
				Name = product.Name,
				Price = product.Price,
				StockPrice = product.StockPrice,
				User = product.User
			};
		}
	}
}
