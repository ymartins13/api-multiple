using Microsoft.AspNetCore.Mvc;
using MultipleAPI.DTOs;
using MultipleAPI.Helpers;

namespace MultipleAPI.Controllers
{
    [ApiController]
    [Route("multiple")]
    public class MultipleController : ControllerBase
    {
        [HttpPost("check11")]
        [ProducesResponseType(typeof(ResponseBase<IList<MultipleResponse>>), 200)]
        [ProducesResponseType(400)]
        public IActionResult CheckMultiple11([FromBody] MultipleRequest request)
        {
            var multiples = new List<MultipleResponse>();
            foreach (var number in request.Numbers)
            {
                var isMultiple = MathHelper.IsMultiple(number, 11);
                multiples.Add(new MultipleResponse(number, isMultiple));
            }
            return Ok(new ResponseBase<IList<MultipleResponse>>(multiples));
        }
    }
}