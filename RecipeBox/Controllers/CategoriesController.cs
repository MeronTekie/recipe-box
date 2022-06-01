using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecipeBox.Conttrollers
{
  public class CategoriesController:Controller
  {
    private readonly RecipeBoxContext _db;

    public  CategoriesController(RecipeBoxContext db)
    {
      _db =db;
    }
    public ActionResult Index()
    {
      List<Category> model =_db.Categories.ToList();

      return View(model);
    }

  }
}