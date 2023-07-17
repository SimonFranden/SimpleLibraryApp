using Microsoft.EntityFrameworkCore;
using SimpleLibraryApp_DataAccess.Data;
using SimpleLibraryApp_DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryApp_DataAccess.Services
{
    public class LentBookService
    {
        private readonly DataContext _context = new();

        public async Task<LentBook> GetLentBookById(int lentBookId)
        {
            var lentBook = await _context.LentBooks.FirstOrDefaultAsync(lb => lb.Id == lentBookId);
            return lentBook;
        }
    }
}
