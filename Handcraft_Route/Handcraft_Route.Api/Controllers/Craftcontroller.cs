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
    public class Craftcontroller : ControllerBase
    {   
        [HttpPost]
        public string post(CraftDto craft) 
        {
            string MessageResult ="";

            string Name = craft.Name;

            string Description = craft.Description;

            string Image = craft.Image;

            string Material = craft.Material;

            if(Name=="" || Description=="" || Image=="" || Material=="") 
            {
                 //cSpell:disable
                MessageResult="No se pudo registrar la artesania...intentelo nuevamente";
            }
            else
            {
                MessageResult="Se ha registrado tu artesania con exito.";
            }
            return MessageResult;

        }
    }
}