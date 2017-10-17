using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TalentsCRUD.Service.Interface;
using TalentsCRUD.WebAPI.ModelView;

namespace TalentsCRUD.WebAPI.Controllers
{
    public class TalentController : ApiControllerBase
    {
        ITalentService talentService;
        public TalentController(ITalentService _talentService)
        {
            talentService = _talentService;
        }
        [HttpPost]
        [Route("api/saveTalent")]
        public IHttpActionResult SaveTalent([FromBody]TalentModelView model)
        {
            try
            {
                return Ok(new { Status = talentService.AddTalent(model.TalentModelViewToTalent()) });
            }
            catch (Exception ex)
            {
                return Ok(new { Status = false, erros = returnError(ex) });
            }

        }
        [HttpPost]
        [Route("api/updateTalent")]
        public IHttpActionResult UpdateTalent([FromBody]TalentModelView model)
        {
            try
            {

               return Ok(new { Status = talentService.UpdateTalent(model.TalentModelViewToTalent()) });
            }
            catch (Exception ex)
            {
                return Ok(new { Status = false, erros = returnError(ex) });
            }

        }
        [HttpGet]
        [Route("api/listTalent")]
        public IHttpActionResult ListTalent()
        {
            try
            {
                return Ok(new { Status = true, Data = talentService.ListTalent() });
            }
            catch (Exception ex)
            {
                return Ok(new { Status = false, erros = returnError(ex) });
            }

        }

        [HttpGet]
        [Route("api/editTalent/{Id}")]
        public IHttpActionResult editTalent(Guid Id)
        {
            try
            {
                return Ok(new { Status = true, Data = new TalentModelView(talentService.EditTalent(Id)) });
            }
            catch (Exception ex)
            {
                return Ok(new { Status = false, erros = returnError(ex) });
            }

        }

        [HttpGet]
        [Route("api/deleteTalent/{Id}")]
        public IHttpActionResult deleteTalent(Guid Id)
        {
            try
            {
                return Ok(new { Status = true, Data = talentService.DeleteTalent(Id) });
            }
            catch (Exception ex)
            {
                return Ok(new { Status = false, erros = returnError(ex) });
            }

        }
    }
}