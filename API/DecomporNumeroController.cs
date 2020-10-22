using dataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API
{
    [ApiController]
    public class DecomporNumeroController : ControllerBase
    {
        public DecomporNumeroController()
        {
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DecomporNumero (CalculoDataTransferObject model)
        {           
            model.numero = 2;
            return CreatedAtAction("", model);
        }
    }
}
