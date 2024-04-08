using System;
using EntityFramework.Models;

namespace EntityFramework.Services.Interfaces
{
	public interface ISettingService
	{
		Task<List<Setting>> GetAllASync();
		Task<Setting> GetByIdAsync(int id);
		Task CreateAsync(Setting setting);
		Task UpdateAsync(int id,Setting setting);
		Task DeleteAsync(int id);
	}
}

