using RecipeBox.Models;
using System.Collections.Generic;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public Recipe()
    {
      this.JoinEntities = new HashSet<RecipeCategory>();
    }
    public int RecipeId { get; set; }
    public string DishName { get; set;}
    public string Origin { get; set; }
    public string Ingredients { get; set; }
    public string Instructions { get; set; }
    public int EstimatedCost { get; set;}
    public virtual ApplicationUser User { get; set;}
    public virtual ICollection<RecipeCategory> JoinEntities { get;}

  }
}