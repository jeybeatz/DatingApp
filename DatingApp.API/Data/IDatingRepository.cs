using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class; //Se crea el metodo "Add" tomomando al elemento "T" como entidad, donde "T" es una clase, esto para agregar usuarios y fotos
         void Delete<T>(T entity) where T: class; // " " " " Este para Eliminar usuarios y fotos
         Task<bool> SaveAll(); // Con este task guardamos los datos en la base de datos
         Task<IEnumerable<User>> GetUsers(); //Para retornar un a lista de usuarios
         Task<User> GetUser(int id); // Para retirnar usuario de manera individual
    }
}