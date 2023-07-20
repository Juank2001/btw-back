using Btw.models;
using Microsoft.AspNetCore.Mvc;


namespace Btw.Controllers
{
    [ApiController]
    [Route("categorys")]
    public class categorysController : ControllerBase
    {
        private http http;

        [HttpGet]
        [Route("listAll")]
        public dynamic listarCategorias()
        {
            http = new http();

            dynamic response = http.httpRequest("get", "categories", "{}");
            return response;            
        }

        [HttpGet]
        [Route("listUnique/{categoryId:int}")]
        public dynamic listarCategoria(int categoryId)
        {
            http = new http();

            dynamic response = http.httpRequest("get", "categories/"+categoryId, "{}");
            return response;
        }

        [HttpGet]
        [Route("products/{Id:int}")]
        public dynamic listarProductos(int Id)
        {
            http = new http();

            dynamic response = http.httpRequest("get", "categories/" + Id+"/products", "{}");
            return response;
        }
    }
}
