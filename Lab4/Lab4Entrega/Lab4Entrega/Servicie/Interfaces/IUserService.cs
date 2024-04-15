

using Lab4Entrega.Data.Dto;
using Lab4Entrega.Data.Entities;

namespace Lab4Entrega.Servicie.Interfaces
{
    public interface IUserService
    {
        User CreateUser(DtoUser user);
    }
}
