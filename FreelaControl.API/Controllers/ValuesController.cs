using FreelaControl.Domain.Entities;
using FreelaControl.Domain.Interfaces;
using FreelaControl.Services.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace FreelaControl.API.Controllers
{
    public class ValuesController : ApiController
    {

        private readonly IUsuarioService _db;

        public ValuesController(IUsuarioService db)
        {
            _db = db;
        }
        // GET api/values
        public async Task<IHttpActionResult> Get()
        {
            var lista = await _db.GetAll();
            return Ok(lista);
        }

        // GET api/values/5
        public async Task<IHttpActionResult> Get(string id)
        {
            return Ok(await _db.Get(id));
        }

        // POST api/values
        public async Task<IHttpActionResult> Post([FromBody]Usuario value)
        {
            return Ok(await _db.Post<UsuarioValidator>(value));
        }

        // PUT api/values/5
        public async Task<IHttpActionResult> Put([FromBody]Usuario value)
        {
            return Ok(await _db.Put<UsuarioValidator>(value));
        }

        // DELETE api/values/5
        public async Task<IHttpActionResult> Delete(string id)
        {
            var item = await _db.Get(id);
            await _db.Delete(item);
            return Ok();
        }
    }
}
