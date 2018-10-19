using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AD

{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Employee_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Last_Name { get; set; }

        [StringLength(50)]
        public string Middle_Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Department_Code { get; set; }

        [StringLength(50)]
        public string Bureau { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string Work_address { get; set; }

        [StringLength(10)]
        public string Work_Phone { get; set; }

        public bool Admin_Flag { get; set; }

        [StringLength(100)]
        public string Work_City { get; set; }

        [StringLength(100)]
        public string Work_State { get; set; }

        [StringLength(25)]
        public string Work_Zip { get; set; }

        [StringLength(100)]
        public string Work_Location { get; set; }

        [StringLength(25)]
        public string Cell_Phone { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Payroll_Title { get; set; }
    }
}
