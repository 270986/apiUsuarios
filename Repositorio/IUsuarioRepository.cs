using System.Collections.Generic;
using apiUsuarios.Models;

namespace apiUsuarios.Repositorio
{
    public interface IUsuarioRepository
    {
         void Add(Usuario user);
        IEnumerable<Usuario> GetAll();

        Usuario Autenticar(string usuario, string senha);
        
        Usuario Find(long id);
        void Remove(long id);
        void Update(Usuario user);
    }
}