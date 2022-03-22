using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;

namespace LearnWeb_Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
