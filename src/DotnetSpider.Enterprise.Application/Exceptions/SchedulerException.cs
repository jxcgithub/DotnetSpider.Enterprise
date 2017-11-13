﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSpider.Enterprise.Application.Exceptions
{
	public class SchedulerException : Exception
	{
		public SchedulerException(string message):base(message)
		{ }

		public SchedulerException(string message, Exception inner) : base(message, inner)
		{

		}
	}
}
