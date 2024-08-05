﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Threading.Tasks;

namespace SuperShop.Helpers
{
	public interface IBlobHelper
	{
		Task<Guid> UploadBlobAsync(IFormFile file, string containerName);

		Task<Guid> UploadBlobAsync(byte[] file, string containerName);

		Task<Guid> UploadBlobAsync(string image, string containerName);


	}
}