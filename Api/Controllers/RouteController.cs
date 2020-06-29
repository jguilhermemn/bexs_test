using Bexs.Domain.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("api/route")]
    public class RouteController : ApiController
    {
        private IRouteApplicationService appService;

        public RouteController()
        {
        }

        public RouteController(IRouteApplicationService appService)
        {
            this.appService = appService;
        }

        [HttpGet]
        [Route("{from}/{to}")]
        public IHttpActionResult Get(string from, string to)
        {
            try
            {
                var result = appService.BuildRoutes(from, to);

                if (result != null)
                    return Ok(result);
                else
                    return Ok("Não foi encontrado nenhum resultado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
