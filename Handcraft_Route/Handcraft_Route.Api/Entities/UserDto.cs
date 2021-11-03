using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Handcraft_Route.Api.Entities
{
        public class UserDto
        {
                public string UserName{get;set;}

                public string Password{get;set;}

                public string RolName{get;set;}
        }
}