using System;
using EntityFramework.Data;
using EntityFramework.Helpers.Exceptions;
using EntityFramework.Models;
using EntityFramework.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Services
{
    public class SettingService : ISettingService
    {
        private readonly AppDbContext _context;
        public SettingService()
        {
            _context = new AppDbContext()
;        }
        public async Task CreateAsync(Setting setting)
        {
            await _context.Settings.AddAsync(setting);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Setting>> GetAllASync()
        {
            return await _context.Settings.ToListAsync();
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
            var data= await _context.Settings.FirstOrDefaultAsync(m => m.Id == id);
            if (data == null) throw new NotFoundException("Data not found");
            return data;
        }

        public Task UpdateAsync(int id, Setting setting)
        {
            throw new NotImplementedException();
        }
    }
}

