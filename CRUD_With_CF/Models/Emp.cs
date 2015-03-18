using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_With_CF.Models
{
    public class Emp
    {
        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public Int32 EmpNo { get; set; }
            [Required(ErrorMessage = " Employee Name Required")]
            [StringLength(20)]
            public String EmpName { get; set; }
            [StringLength(50)]
            [Required(ErrorMessage = " Employee Address Required")]
            public String EmpAdd { get; set; }
            [Required(ErrorMessage = " Employee Salary Required")]
            public Int32 EmpSal { get; set; }
            public bool IsActive { get; set; }

      }
    
}