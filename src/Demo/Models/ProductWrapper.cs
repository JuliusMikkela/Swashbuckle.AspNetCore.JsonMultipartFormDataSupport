﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.JsonMultipartFormDataSupport;

namespace Demo.Models {
	public class ProductWrapper {
		[FromJson] // <-- This attribute is required for binding.
		public Product Product { get; set; }

		public IFormFileCollection  Files { get; set; }
	}
}