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

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class FoodTourcontroller : ControllerBase
    {
        [HttpPost]
        public string post(FoodTourDto FoodTour)
        {
            string MessageResult = "";

            string NameFoodTour = FoodTour.NameFoodTour;

            string DescriptionFoodTour = FoodTour.DescriptionFoodTour;

            string MeetingPoint = FoodTour.MeetingPoint;

            string MenuDescription = FoodTour.MenuDescription;

            string ImageFoodUno = FoodTour.ImageFoodUno;

            string ImageFoodDos = FoodTour.ImageFoodDos;

            string ImageFoodTres = FoodTour.ImageFoodTres;

            if(NameFoodTour=="" || DescriptionFoodTour=="" || MeetingPoint=="" || MenuDescription=="" || ImageFoodUno=="" || ImageFoodDos=="" || ImageFoodTres=="")
            {
                //cSpell:disable
                MessageResult = "No se pudo registrar el tour...intentelo nuevamente.";
            }
            else
            {
                MessageResult = "Se registro el tour exitosamente.";
            }
            return MessageResult;
        }
    }
}