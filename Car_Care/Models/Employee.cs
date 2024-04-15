namespace Car_Care.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public int id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [StringLength(20)]
        [Required(ErrorMessage = "Employee Id is required")]
        public string Employee_Id { get; set; }

        [Required(ErrorMessage = "Mobile Number is required")]
        public long? Mobile_Number { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Employee Id Proof is required")]
        public string Emp_Id_Proof { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        public int? Salary { get; set; }
    }
}
