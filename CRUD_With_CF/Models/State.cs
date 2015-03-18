using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_With_CF.Models
{
    public class State
    {
        [Key]
        public int StaCode { get; set; }
        [Required]
        public String StaName { get; set; }
        //foreign key Country
        public int CntCode { get; set; }
        [ForeignKey("CntCode")]
        public Country Country { get; set; }
        //foreign key City
        public ICollection<City> Cities { get; set; }
    }
}