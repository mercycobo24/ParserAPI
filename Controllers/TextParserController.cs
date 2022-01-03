using MediatR;
using Microsoft.AspNetCore.Mvc;
using ParserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextParserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TextParserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [ProducesResponseType(typeof(GridDataResponse[]),200)]
        [HttpPost]
        public async Task<IActionResult> GetTextByRowsAndColumns([FromBody] FixedWithParser request)
        {
            //ProParserApi.Handlers.GridData class that implements IGridData interface
            try
            {
                var res = await _mediator.Send<GridDataResponse>(request);
                return Ok(res.Rows);
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message);
            }
          
        }
    }
}
