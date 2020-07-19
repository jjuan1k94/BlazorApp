using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class InputOutputEntity
    {
        [Key]
        [StringLength(50)]
        public string InputOutputId { get; set; }
        [Required]
        public DateTime InputOutputDate { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsInput { get; set; }
        public string StorageId { get; set; }
        public StorageEntity Storage { get; set; }
    }
}
