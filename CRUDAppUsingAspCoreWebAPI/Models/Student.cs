using System.ComponentModel.DataAnnotations;

namespace CRUDAppUsingAspCoreWebAPI.Models
{
   
        public class Student
        {
            public int id { get; set; }
            [Required]
            public string name { get; set; }
            [Required]
            public string subject { get; set; }
            [Required]
            public string dept { get; set; }
         

    }


}
