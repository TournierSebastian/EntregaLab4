using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Lab4Entrega.Data.Entities
{
    public class User
    {
        [Key]
        public int idUser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }

        [JsonIgnore]
        public ICollection<TodoItem> TodoItems { get; set; }
    }
}
