using System.ComponentModel.DataAnnotations;

public class mydata{
    [Display(Name = "Product Id")]
    [Key]
    [Required(ErrorMessage = "ID is Compulsory")]
    public int Id{get;set;}
    [Required(ErrorMessage ="Name Cannot be Blank")]
    public string Name{get;set;}
    [Range(100, 900, ErrorMessage = "Price should be between 100 and 900")]
    public int Price{get;set;}
    public int Stock{get;set;}
}