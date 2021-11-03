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

    [ApiController]
    [Route("api/[controller]")]
    public class Craftmancontroller : ControllerBase
    {
        

        [HttpPost]
        public string post(CraftmanDto craftman)
        {
            string MessageResult = "";

            string FirstName = craftman.FirstName;
            string LastName = craftman.LastName;
            string Address = craftman.Address;
            string Municipality = craftman.Municipality;
            string Telephone = craftman.Telephone;
            string Email = craftman.Email;
            string Association = craftman.Association;
            string Logo = craftman.Logo;

            if (FirstName=="" || LastName=="" || Address=="" || Municipality=="" || Telephone=="" || Email=="" ||Association=="" || Logo=="") 
            {
                //cSpell:disable
                MessageResult ="No se pudo registrar al artesano...Intentelo nuevamente";
            }
            else
            {
                MessageResult ="Se ha registrado a "+craftman.FirstName+" "+craftman.LastName+" exitosamente";
            }
            return MessageResult;
        
        }
    }
}