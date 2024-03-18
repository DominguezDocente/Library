using AspNetCoreHero.ToastNotification.Abstractions;
using Library.Web.Core;
using Library.Web.Data;
using Library.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Web.Services
{
    public interface IAuthorsService
    {
        public Task<Response<IEnumerable<Author>>> GetListAsync();
    }

    public class AuthorsService : IAuthorsService
    {
        private readonly DataContext _context;
        private readonly INotyfService _notyf;

        public AuthorsService(DataContext context, INotyfService notyf)
        {
            _context = context;
            _notyf = notyf;
        }

        public async Task<Response<IEnumerable<Author>>> GetListAsync()
        {
            try
            {
                _notyf.Error("Debe ajustar los errores de validación");
                IEnumerable<Author> list = await _context.Authors.ToListAsync();

                return new Response<IEnumerable<Author>> { IsSuccess = true, Message = "Lista obtenida con éxito", Result = list };

            }
            catch (Exception ex)
            {
                return new Response<IEnumerable<Author>> { IsSuccess = false, Errors = new List<string> { ex.Message } };
            }
        }
    }
}
