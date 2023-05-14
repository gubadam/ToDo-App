using System.ComponentModel.DataAnnotations.Schema;

namespace Todo_App.Models {
    public class Task {
        public int Id { get; set; }

        [Column(TypeName="ntext")]
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual int ListId { get; set; }
    }
}
