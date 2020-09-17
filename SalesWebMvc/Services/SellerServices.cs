using SalesWebMvc.Data;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using SalesWebMvc.Services.Exceptions;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerServices
    {
        private readonly SalesWebMvcContext _context;
        public SellerServices(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();

        }

        public async Task InsertAsync(Seller seller)
        {
            _context.Add(seller);
            await _context.SaveChangesAsync();
        }
        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(X => X.Id == id);
        }
        public async Task DeleteAsync(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Remove(obj);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateASync(Seller seller)
        {
            bool hasid = await _context.Seller.AnyAsync(x => x.Id == seller.Id);
            if (!hasid)
            {
                throw new NotFoundException("Id not found.");
            }
            try
            {
                _context.Update(seller);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbUpdateException(e.Message);
            }


        }

    }
}

