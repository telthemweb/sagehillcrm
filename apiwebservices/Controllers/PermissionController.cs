using apiwebservices.Databasemanager;
using apiwebservices.DTO;
using apiwebservices.DTO.permission;
using apiwebservices.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;
using System.Security;

namespace apiwebservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        public PermissionController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Permision>>> Get()
        {
            var permisions = await _databaseContext.permision.ToListAsync();
            return Ok(permisions);
        }

        [HttpGet("{submoduleId}")]
        public async Task<ActionResult<List<Permision>>> GetPermissionBySubmoduleId(int id)
        {
            var role = await _databaseContext.permision.Where(r => r.submoduleId== id).ToListAsync();
            return Ok(role);
        }

        [HttpPost]
        public async Task<HttpStatusCode> CreateUser([FromBody] createPermissiondto pmdto)
        {
            var data = new Permision()
            {
                submoduleId = pmdto.submoduleId,
                name = pmdto.name,
            };
             _databaseContext.permision.Add(data);
            await _databaseContext.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        
       [HttpGet("{assignedByRole/id/roleId")]
        public async Task<ActionResult<List<Permision>>> assignedByRole(int id,int submoduleId)
        {
            var dbpermissions = await _databaseContext.permision.Where(r => r.submoduleId == submoduleId).ToListAsync();
            var role = await _databaseContext.roles.FindAsync(id);
            List<Permision> permisions = new List<Permision>();
            dbpermissions.ForEach(permission =>
            {
                bool assigned = false;
                var roles = role.permisions.ToList();
                roles.ForEach(perm =>
                {
                    if (perm.id == permission.id)
                    {
                        assigned = true;
                    }
                });

                permisions.Add(permission);
            });
            return Ok(permisions);
        }

        [HttpGet("update")]
        public async Task<HttpStatusCode> updateRole(UpdatePermission updateRequst)
        {
            var permision = await _databaseContext.permision.FirstOrDefaultAsync(r => r.id == updateRequst.id);
            permision.submoduleId = updateRequst.submoduleId;
            permision.name = updateRequst.name;
            await _databaseContext.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

        [HttpDelete]
        public async Task<HttpStatusCode> Delete(int id)
        {
            var idr = new Permision()
            {
                id = id
            };
            _databaseContext.permision.Attach(idr);
            _databaseContext.permision.Remove(idr);
            await _databaseContext.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
    }
}
