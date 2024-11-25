using System;
using System.ComponentModel.DataAnnotations;

public class Class1
{
    public Class1()
    {
        public int ID {  get; set; }
    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }
    }
}