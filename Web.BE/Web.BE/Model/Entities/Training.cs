using System.ComponentModel.DataAnnotations;

namespace Web.BE.Model.Entities
{
    public class Training
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Issuer { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }

        public DateTime? IssuedDate { get; set; }
    }
}
   
