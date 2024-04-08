using System;
using EntityFramework.Services;
using EntityFramework.Services.Interfaces;

namespace EntityFramework.Controllers
{
	public class SettingController
	{
		private readonly ISettingService _settingService;
		public SettingController()
		{
			_settingService = new SettingService();
		}

		public async Task GetAllAsync()
		{
			var datas = await _settingService.GetAllASync();
			foreach (var item in datas)
			{
				string data = $"Name:{item.Name} , Email:{item.Email} , Address:{item.Address} , Phone: {item.Phone}";
				Console.WriteLine(data);
			}
		}

		public async Task GetById()
		{
			Console.WriteLine("Enter id");
			int id = Convert.ToInt32(Console.ReadLine());
			try
			{
                var data = await _settingService.GetByIdAsync(id);
                string result = $"Name:{data.Name} , Email:{data.Email} , Address:{data.Address} , Phone: {data.Phone}";
                Console.WriteLine(result);
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
        }
	}
}

