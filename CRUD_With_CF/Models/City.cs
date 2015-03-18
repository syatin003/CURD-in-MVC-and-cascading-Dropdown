using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_With_CF.Models
{
    public class City
    {
        [Key]
        public int CtyCode { get; set; }
        [Required]
        public String CtyName { get; set; }
        //foriegn key State
        public int StaCode { get; set; }
        [ForeignKey("StaCode")]
        public State State { get; set; }
    }
}