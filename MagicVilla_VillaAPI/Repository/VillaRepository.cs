﻿using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            entity.UpdatedDateTime = DateTime.Now;
             _db.Vilas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}
