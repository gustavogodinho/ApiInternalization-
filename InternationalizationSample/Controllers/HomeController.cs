using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternationalizationSample.Localization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace InternationalizationSample.Controllers
{
   
    [Route("{culture:culture}/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<Resource> localizer;

        public HomeController(IStringLocalizer<Resource> localizer)
        {
            this.localizer = localizer;

        }

        /// <summary>
        /// Teste retorna mensagem de acordo com a Cultura informada na rota.
        /// </summary>
        [HttpGet("mensagem")]
        public string Get()
        {
            return localizer["Teste"];
        }

        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <param name="item"></param>
        /// <returns>teste nao implementado</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>            
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<string> Create(string item)
        {

            return CreatedAtRoute("GetTodo", new { id = 0 }, item);
        }

    }
}
