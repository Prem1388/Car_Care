namespace Car_Care.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Register")]
    public partial class Register
    {
        public int id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        public long? Mobile_Number { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [StringLength(200)]
        public string Address { get; set; }
    }
}
