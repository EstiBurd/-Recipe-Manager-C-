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
    public class CategoryController : ApiController
    {
        [HttpGet]
        public  List<Category> getCategory()
        {
            return DB.C;
        }
    }
}
