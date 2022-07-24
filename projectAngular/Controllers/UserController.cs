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
    public class UserController : ApiController
    {
        [HttpPost]
       // [Route("AddUser")]
        public int AddUser(User u)
        {
            return DB.AddUser(u);
        }   
            
        
        [HttpPost]
        public int IsWorng(User u)
        {
            return DB.IsWorng(u);
        }
        [HttpGet]

        //[Route("GetUserById")]
        public User GetUserById(int code)
        {
            return DB.U.FirstOrDefault((u) => u.CodeUser == code);
        }
    }
}
