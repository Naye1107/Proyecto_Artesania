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
    public class CraftTourcontroller : ControllerBase
    {
        [HttpPost]
        public string post(CraftTourDto Tour)
        {
            string MessageResult= "";

            string NameTour = Tour.NameTour;

            string Description = Tour.Description;

            string MeetingPoint = Tour.MeetingPoint;

            string Craft = Tour.Craft;

            string MatrialCraft = Tour.MatrialCraft;

            if(NameTour=="" || Description=="" || MeetingPoint=="" || Craft=="" || MatrialCraft=="")
            {
                //cSpell:disable
                MessageResult="No se pudo registrar el tour...intentelo nuevamente.";
            }
            else
            {
                MessageResult="Se ha resgistrado el tour exitosamente.";
            }
            return MessageResult;
        }
    }
}