using Microsoft.AspNetCore.Mvc;
using Model.Tables;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormController : ControllerBase
    {
        [HttpGet]
        [Route("GetAllInputs")]
        public List<Input> GetAllInputs()
        {
            return Controller.GetAllInputs();
        }

        [HttpGet]
        [Route("GetAllForms")]
        public List<Form> GetAllForms() 
        {
            return Controller.GetAllForms();
        }
    }
}
