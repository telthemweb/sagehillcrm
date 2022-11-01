using apiwebservices.Databasemanager;
using apiwebservices.DTO;
using apiwebservices.DTO.SystemModuleDtO;
using apiwebservices.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace apiwebservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemModulesController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        public SystemModulesController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<SystemModule>>> Get()
        {
            var systemmodules = await _databaseContext.systemModule.ToListAsync();
            return Ok(systemmodules);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SystemModule>>> getModulesByRole(int id)
        {
            var modules = await _databaseContext.systemModule.ToListAsync();
            var role = await _databaseContext.roles.FirstOrDefaultAsync(r => r.id == id);

            //list of modules
            List<SystemModule> result = new List<SystemModule>();

            modules.ForEach(module =>
            {
                bool assinged = false;
                var datarolemo = role.systemModule.ToList();
                datarolemo.ForEach(systemodule =>
                {
                if (systemodule.id == module.id)
                {
                    assinged = true;
                }
                });

                result.Add(module);


            });
            return Ok(result);
        }

        [HttpPost]
        public async Task<HttpStatusCode> CreateModule([FromBody] CreateSystemModuleDto mde)
        {
            var checkmodule = await _databaseContext.systemModule.FirstOrDefaultAsync(r => r.name == mde.name);
            if (checkmodule == null)
            {
                var module = new SystemModule()
                {
                    name = mde.name,
                    icon = mde.icon,
                    widget = mde.widget,
                    description = mde.description,
                    status=mde.status
                };
                _databaseContext.systemModule.Add(module);

                await _databaseContext.SaveChangesAsync();
                return HttpStatusCode.Created;
            }
            else
            {
                return HttpStatusCode.BadRequest;
            }
            
        }
    }
}
