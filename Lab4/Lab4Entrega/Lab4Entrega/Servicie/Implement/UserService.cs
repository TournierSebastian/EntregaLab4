using Lab4Entrega.Data;
using Lab4Entrega.Data.Dto;
using Lab4Entrega.Data.Entities;
using Lab4Entrega.Servicie.Interfaces;

namespace Lab4Entrega.Servicie.Implement
{
    public class UserService:IUserService
    {

        private readonly Context _Context;


        public UserService(Context context)
        {
            _Context = context;
        }

        public User CreateUser(DtoUser user)
        {
            User newUser = new User
            {
                Name = user.Name,
                Email = user.Email,
                Address = user.Address
            };

            _Context.Users.Add(newUser);
            _Context.SaveChanges();

        
            return newUser;
        }
    }
}
