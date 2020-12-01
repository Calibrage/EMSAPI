using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Identity
{
    public class AuthRepository
    {
        private AuthContext _ctx;
        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        public IdentityResult RegisterUser(string UserName, string Password)
        {
            IdentityUser user = new IdentityUser();
            IdentityResult result = new IdentityResult();
            try
            {
                user = new IdentityUser
                {
                    UserName = UserName
                };

                result = _userManager.Create(user, Password);

                if (!result.Succeeded)
                {
                    user.Id = null;
                }

            }
            catch (Exception ex)
            {
                user.Id = null;
            }

            return result;
        }
    }
}
