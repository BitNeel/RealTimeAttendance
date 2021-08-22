using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Controllers
{
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/local-error")]
        public IActionResult LocalError([FromServices] IWebHostEnvironment webHostEnv)
        {
            if(webHostEnv.EnvironmentName != "Development")
            {
                throw new InvalidOperationException("This should not be invoked in non-development environment");
            }
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return Problem(detail: context.Error.StackTrace, title: context.Error.Message);
        }
    }
}
