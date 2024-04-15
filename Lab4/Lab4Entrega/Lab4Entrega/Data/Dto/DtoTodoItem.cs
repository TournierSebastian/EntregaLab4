using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace Lab4Entrega.Data.Entities
{
    public class DtoTodoItem
    {
     
        public string Tittle { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

    }
}
