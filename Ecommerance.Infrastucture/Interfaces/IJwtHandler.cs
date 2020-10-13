using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerance.Infrastucture.Interfaces
{
    public interface IJwtHandler
    {
        String CreateToken(Guid userId, string role);


    }
}
