using ApiRestBilling.Models.DTOs;
using RestBilling.Models;

namespace RestBilling.Repositorio.IRepository
{
    public interface IUserRepository
    {
        int GetAllUsers { get; }

        ICollection<AppUser> GetAll();
        int AllUsers { get; }

        Task GetAllUsersAsync();
        AppUser GetById(int id);
        bool IsUnique(String userName);
        Task<UserLoginResponseDTO> Login(UserLoginDTO userLoginDTO);
        Task LoginAsync(UserLoginDTO usuarioLoginDto);
        Task RegisterAsync(UserRegisterDTO usuarioRegistroDto);
        Task<UserLoginDTO> Registro(UserRegisterDTO userLoginDTO);
    } 
}
