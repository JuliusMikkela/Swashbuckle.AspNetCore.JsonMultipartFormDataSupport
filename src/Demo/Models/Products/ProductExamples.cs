﻿using Swashbuckle.AspNetCore.Filters;

namespace Demo.Models.Products;

public class ProductExamples : IExamplesProvider<Product> {
	public Product GetExamples() {
		var product = new Product {
			Id = Guid.NewGuid(),
			Name = "Example",
			Type = ProductType.Phone
		};
		return product;
	}
}