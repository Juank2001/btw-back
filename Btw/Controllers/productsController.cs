using Btw.models;
using Microsoft.AspNetCore.Mvc;

namespace Btw.Controllers
{
    [ApiController]
    [Route("products")]
    public class productsController: ControllerBase
    {
        private http http;

        [HttpGet]
        [Route("listAll/{limit:int}/{offset:int}")]
        public dynamic listarCategorias(int limit, int offset)
        {
            http = new http();

            dynamic response = http.httpRequest("get", "products?offset="+offset+"&limit="+limit, "{}");
            return response;
        }
    }
}
