﻿using DotnetSpider.Enterprise.Application.Log.Dto;
using DotnetSpider.Enterprise.Application.Task.Dtos;
using MongoDB.Bson;

namespace DotnetSpider.Enterprise.Application.Log
{
	public interface ILogAppService
	{
		void Sumit(LogInputDto input);

		PagingLogOutDto QueryLogs(PagingLogInputDto input);
	}
}
