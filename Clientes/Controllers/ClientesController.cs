using Clientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteContext _context;
        public ClientesController(ClienteContext context)
        {
            _context = context;
            
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            return await _context.Clientes.ToListAsync();
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> Get(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        // POST api/<ClientesController>
        [HttpPost]
        public async Task<ActionResult<Cliente>> Post([FromBody] Cliente value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Clientes.Add(value);
            await _context.SaveChangesAsync();

            return RedirectToAction("Get", new { id = value.Id });
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Cliente>> Put(int id, [FromBody] Cliente value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            

            Cliente c = _context.Clientes.Find(id);
            if (c.Id != value.Id)
                return BadRequest();

            c = value;
            await _context.SaveChangesAsync();

            return RedirectToAction("Get", new { id = c.Id });
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Cliente c = _context.Clientes.Find(id);
            _context.Clientes.Remove(c);
            return RedirectToAction("Get");
        }
    }
}
