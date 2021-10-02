using Lab.Tp7.Entities;
using Lab.Tp7.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace Lab.Tp8.WebApi.Controllers
{
    public class ShipperController : ApiController
    {
        ShipperLogic shipperLogic = new ShipperLogic();
        // GET: api/Shipper

        public IHttpActionResult Get()
        {
            try
            {
                List<Shipper> listShippers = shipperLogic.GetAll();
                return Ok(listShippers);
            }
            catch (Exception)
            {
                return BadRequest("Ocurrio un error");
            }
            
        }

        // GET api/Shipper/3
        public IHttpActionResult Get(int id)
        {
            if (id == null) { return NotFound(); }
            try
            {
                Shipper shipper = shipperLogic.GetOne(id);
                if (shipper == null) { return NotFound(); }
                return Ok(shipper);
            }
            catch (Exception)
            {
                return BadRequest("Ocurrio un error");
            }
            
        }

        // POST api/Shipper
        [HttpPost]
        public IHttpActionResult Post([FromBody] Shipper shipper)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
                
            try
            {
                shipperLogic.Add(shipper);
                return Ok("Insertado Correctamente");
            }
            catch (Exception)
            {
                return BadRequest("Ocurrio un error");
            }
            
        }

        // PUT api/Shipper/5

        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Shipper shipper)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            if(id == null) { return BadRequest("El ID de la URL es nulo"); }

            if (shipper.ShipperID != id) { return BadRequest("El ID del body no coincide con el ID de la URL"); }

            try
            {
                shipperLogic.Update(shipper);
                return Ok("Actualizado Correctamente");
            }
            catch (Exception)
            {
                return BadRequest("Ocurrio un error");
            }
        }

        // DELETE api/Shipper/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if(id == null) { return NotFound(); }

            try
            {
                shipperLogic.Delete(id);
                return Ok("Eliminado correctamente");
            }
            catch (Exception)
            {
                return BadRequest("Ocurrio un error");
            }
        }

    }
}
