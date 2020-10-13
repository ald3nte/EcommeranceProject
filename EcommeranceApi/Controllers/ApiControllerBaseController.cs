using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EcommeranceApi.Controllers
{
    [Route("[controller]")]
    public class ApiControllerBase : Controller
    {
        protected Guid UserId => User?.Identity.IsAuthenticated == true ?
            Guid.Parse(User.Identity.Name) : 
            //W JWT HANDLERZE zrobiliśmy w claimsach : new Claim(JwtRegisteredClaimNames.UniqueName, userId.ToString()),
            Guid.Empty;
    }
}