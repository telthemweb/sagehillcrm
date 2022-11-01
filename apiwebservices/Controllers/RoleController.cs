using apiwebservices.Databasemanager;
using apiwebservices.DTO;
using apiwebservices.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;

namespace apiwebservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        public RoleController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<RoleRequest>>> Get()
        {
            var listroles = await _databaseContext.roles.Select(r=> new RoleRequest
            {
                id=r.id,
                name=r.name,
                status=r.status,
                level=r.level,
                created_at=r.created_at,
            }).ToListAsync();
            if (listroles.Count < 0)
            {
                return NotFound();
            }
            return Ok(listroles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<RoleRequest>>> GetById(int id)
        {
            var roleid = await _databaseContext.roles.Select(r => new RoleRequest
            {
                id = r.id,
                name = r.name,
                status = r.status,
                level = r.level,
                created_at = r.created_at,
            }).FirstOrDefaultAsync(r=>r.id==id);
            if (roleid ==null)
            {
                return NotFound();
            }
            return Ok(roleid);
        }

        [HttpPost]
        public async Task<HttpStatusCode> CreateRole(RoleRequest role)
        {
            var datarole = new Role()
            {
               name = role.name,
               level=role.level
            };
            _databaseContext.roles.Add(datarole);

            await _databaseContext.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        [HttpGet("update")]
        public async Task<HttpStatusCode> updateRole(RoleUpdateRequst updateRequst)
        {
            var roleid = await _databaseContext.roles.FirstOrDefaultAsync(r => r.id == updateRequst.id);
            roleid.name = updateRequst.name;
            roleid.level = updateRequst.level;
            await _databaseContext.SaveChangesAsync();

            return HttpStatusCode.OK;
        }

        [HttpDelete("{id}")]
        public async Task<HttpStatusCode> Delete(int id)
        {
            var idr = new Role()
            {
                id = id
            };
            _databaseContext.roles.Attach(idr);
            _databaseContext.roles.Remove(idr);
            await _databaseContext.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

    }
}
