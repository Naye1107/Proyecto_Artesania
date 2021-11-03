using System.Security.AccessControl;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Handcraft_Route.Api.Entities;


namespace Handcraft_Route.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Logincontroller : ControllerBase
    {
        [HttpPost]
        public string post(UserDto User)
        {
            string MessageResult="";

            string UserName = User.UserName;

            string Password = User.Password;

            string RolName = User.RolName;

            if (UserName=="" || Password=="" || RolName=="")
            {
                //cSpell:disable
                MessageResult="No se pudo iniciar sesión...compruebe su información.";
            }
            else
            {
                MessageResult="Se ha iniciado sesión exitosamente en la cuenta de "+User.UserName+".";
            }
            return MessageResult;

        }
    }
}