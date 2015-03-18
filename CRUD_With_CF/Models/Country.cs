using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_With_CF.Models
{
    public class Country
    {
        [Key]
        public int CntCode { get; set; }
        [Required]
        public String CntName { get; set; }
        //foriegn key state
        public ICollection<State> States {get;set;} 
 
    }
}