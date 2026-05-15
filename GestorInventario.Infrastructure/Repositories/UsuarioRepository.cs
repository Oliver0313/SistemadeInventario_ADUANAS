using GestorInventario.Application.Interfaces.Repositories;
using GestorInventario.Domain.Entities;
using GestorInventario.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorInventario.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    
        {
        private readonly AppDbContext _context;
        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CrearAsync(Domain.Entities.Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);

            await _context.SaveChangesAsync();
        }

        public async Task EliminarAsync(Domain.Entities.Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);

            await _context.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Domain.Entities.Usuario usuario)
        {
            _context.Usuarios.Update(usuario);

            await _context.SaveChangesAsync();
        }

        public async Task<Domain.Entities.Usuario> ObtenerPorIdAsync(int id)
        {
            return await _context.Usuarios.FindAsync(id);

        }

        public async Task<Domain.Entities.Usuario> ObtenerPorCorreoAsync(string correo)
        {
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return await _context.Usuarios
           .FirstOrDefaultAsync(u => u.Correo == correo);
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }

        public async Task<IEnumerable<Domain.Entities.Usuario>> ObtenerTodosAsync()
        {
            return await _context.Usuarios.ToListAsync();
        }
    }
}
