using projectAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace projectAngular.Controllers
{
    [EnableCors(methods: "*", headers: "*", origins: "*")]
    [RoutePrefix("api/Recipe")]
    public class RecipeController : ApiController
    {
        [HttpGet]
        [Route("getRecipe")]
        public List<Recipe> getRecipe()
        {
            return DB.R;
        }
        [HttpPost]
      
        public int AddRecipe(Recipe newR)
        {
            return DB.AddRecipe(newR);

        }
        public void EditRecipe(Recipe newR)
        {
            for (int i = 0; i < DB.R.Count; i++)
            {
                if (newR.CodeRecipe == DB.R[i].CodeRecipe)
                {
                    DB.R[i] = newR;
                }

            }
        }
        }
}
