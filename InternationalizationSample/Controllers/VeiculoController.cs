using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InternationalizationSample.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace InternationalizationSample.Controllers
{
    [Route("{culture:culture}/[controller]")]
    public class VeiculoController : Controller
    {
        private readonly IStringLocalizer<Resource> localizer;

        public VeiculoController(IStringLocalizer<Resource> localizer)
        {
            this.localizer = localizer;

        }

        /// <summary>
        /// Deletes a specific TodoItem.
        /// </summary>
        [HttpGet("veiculo")]
        public string Get()
        {

            return localizer["Home"];
        }
    }
}
