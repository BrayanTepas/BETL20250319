using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BETL20250319.AppWebMVC.Models;

public partial class Category
{
    public int CategoryId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [Display(Name = "categoria")]
    public string CategoryName { get; set; } = null!;
    [Display(Name = "descripcion")]
    public string? Description { get; set; }

    
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
