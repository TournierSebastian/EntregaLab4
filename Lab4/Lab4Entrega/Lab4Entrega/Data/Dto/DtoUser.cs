using Lab4Entrega.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab4Entrega.Data.Dto
{
    public class DtoUser
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

    }
}
