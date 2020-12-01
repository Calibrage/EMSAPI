
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using API.Models;
using Repository.Identity;

namespace API.Controllers
{    
    public class LoginController : ApiController
    {
        private AuthRepository _repo = null;
        private AuthContext _db;

        private IAuthenticationManager Authentication
        {
            get { return Request.GetOwinContext().Authentication; }
        }
        public LoginController()
        {
            _repo = new AuthRepository();
            _db = new AuthContext();
        }
        
        [AllowAnonymous]
        [Route("api/Login/Register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = _repo.RegisterUser(userModel.UserName, userModel.Password);


           

            return Ok();
        }


    }
}
