using RegistroYLoginPost.Data;
using RegistroYLoginPost.Models;

namespace RegistroYLoginPost.Repositories
{
    
    public class RepositoryUsuarios
    {
        //Llamamos al context
        private UsuariosContext context;

        public RepositoryUsuarios(UsuariosContext context)
        {
            this.context = context;
        }

        // FUNCIONALIDAD DEL REGISTRO

        ///////

        //Funcion para sacar el id maximo
        private int GetMaxIdUsuario()
        {
            if (this.context.Usuarios.Count() == 0)
            {
                return 1;
            }
            else
            {
                return this.context.Usuarios.Max(z => z.IdUsuario) + 1;
            }
        }

        public async Task RegisterUser(string email, string password)
        {
            Usuario user = new Usuario();
            user.IdUsuario = this.GetMaxIdUsuario();
            user.Email = email;
            user.Password = password;

            this.context.Usuarios.Add(user);
            await this.context.SaveChangesAsync();
        }
        ///FUNCIONALIDAD DEL LOGIN
        public Usuario GetUserByNamePass(string email, string password)
        {
            return this.context.Usuarios.Where
                (x => x.Email == email && x.Password == password).AsEnumerable().FirstOrDefault();
        }
    }
}
