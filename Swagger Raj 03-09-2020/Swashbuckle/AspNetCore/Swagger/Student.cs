using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Swashbuckle.AspNetCore.Swagger
{
    public class Student
{
    public int Id { get; set; }


    public string Name { get; set; }

    [Required]
    [StringLength(70,MinimumLength =5)]
    public string Address { get;set;}
}
}
