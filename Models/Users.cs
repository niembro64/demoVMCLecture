using System;
using System.ComponentModel.DataAnnotations;

namespace demoVMCLecture.Models
{
  public class User
  {
    
    [Required]
    public string Name { get; set; }

    [Required]
    [MinLength(3)]
    public string Color { get; set; }

    [Range(0, 10)]
    public int Number { get; set; }
  }
}