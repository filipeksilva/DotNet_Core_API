using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace DotNet_Core_API.Controllers
{
    [Route("")]
    [ApiController]
    [EnableCors("PermitirApiRequest")]
    public class HomeController : ControllerBase
    {
        public Apresentacao Index()
        {
            return new Apresentacao();
        }
    }
}
