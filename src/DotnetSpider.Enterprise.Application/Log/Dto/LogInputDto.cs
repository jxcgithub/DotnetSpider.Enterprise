﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotnetSpider.Enterprise.Application.Log.Dto
{
	public class LogInputDto
	{
		[Required]
		public string Token { get; set; }

		[Required]
		public dynamic LogInfo { get; set; }

		[Required]
		public string Identity { get; set; }
	}
}
