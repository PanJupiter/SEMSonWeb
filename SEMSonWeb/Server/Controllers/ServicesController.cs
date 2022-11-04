using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SEMSonWeb.Shared;
using System.Net;

namespace SEMSonWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IWebHostEnvironment _env;
        public ServicesController(DataContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        
        [HttpPost("login")]
        public async Task<ActionResult<string>>Login(UserDto request)
        {
            string token = request.UserName;
            await _context.SPClientUserdb.ToListAsync();
            return token;
        }
        [HttpGet("GetUser")]
        public async Task<ActionResult<List<SPClientUser>>> GetDbSPClientUser()
        {
            if (_context != null)
            {
                var data = await _context.SPClientUserdb.Include(sh => sh.LSPClientProfile).Join(_context.SPClientClassdb,
                    a => a.LSPClientProfile.PHClassCode,
                    b => b.PHClassCode,(a,b) => new SPClientUser
                    {
                        PHProfileCode = a.PHProfileCode,
                        PHUserCode = a.PHUserCode,
                        PHUserName = a.PHUserName,
                        PHUserPassword = a.PHUserPassword,
                        PHUserState = a.PHUserState,
                        PHUserwhenCreate = a.PHUserwhenCreate,
                        PHUserwhenEdit = a.PHUserwhenEdit,
                        PHUserWhoCreate = a.PHUserWhoCreate,
                        LSPClientProfile = new SPClientProfile
                        {
                            PHClassCode = a.LSPClientProfile.PHClassCode,
                            PHDepCode = a.LSPClientProfile.PHDepCode,
                            PHPosCode = a.LSPClientProfile.PHPosCode,
                            PHPreCode = a.LSPClientProfile.PHPreCode,
                            PHProfileClassroom = a.LSPClientProfile.PHProfileClassroom,
                            PHProfileCode = a.LSPClientProfile.PHProfileCode,
                            PHProfileEmail = a.LSPClientProfile.PHProfileEmail,
                            PHProfileNameImg = a.LSPClientProfile.PHProfileNameImg,
                            PHProfileStorageImg = a.LSPClientProfile.PHProfileStorageImg,
                            PHProfilefName = a.LSPClientProfile.PHProfilefName,
                            PHProfileIDcard = a.LSPClientProfile.PHProfileIDcard,
                            PHProfileIDstudent = a.LSPClientProfile.PHProfileIDstudent,
                            PHProfilelName = a.LSPClientProfile.PHProfilelName,
                            PHProfilePhone = a.LSPClientProfile.PHProfilePhone,
                            PHwhenCreate = a.LSPClientProfile.PHwhenCreate,
                            PHwhenEdit = a.LSPClientProfile.PHwhenEdit,
                            PHWhoCreate = a.LSPClientProfile.PHWhoCreate,
                            PHWhoEdit = a.LSPClientProfile.PHWhoEdit,
                            LSPClientDep = a.LSPClientProfile.LSPClientDep,
                            LSPClientPos = a.LSPClientProfile.LSPClientPos,
                            LSPClientPre = a.LSPClientProfile.LSPClientPre,
                            LSPClientClass = b
                        }
                    }).Join(_context.SPClientDepdb,
                    a => a.LSPClientProfile.PHDepCode,
                    b => b.PHDepCode, (a, b) => new SPClientUser
                    {
                        PHProfileCode = a.PHProfileCode,
                        PHUserCode = a.PHUserCode,
                        PHUserName = a.PHUserName,
                        PHUserPassword = a.PHUserPassword,
                        PHUserState = a.PHUserState,
                        PHUserwhenCreate = a.PHUserwhenCreate,
                        PHUserwhenEdit = a.PHUserwhenEdit,
                        PHUserWhoCreate = a.PHUserWhoCreate,
                        LSPClientProfile = new SPClientProfile
                        {
                            PHClassCode = a.LSPClientProfile.PHClassCode,
                            PHDepCode = a.LSPClientProfile.PHDepCode,
                            PHPosCode = a.LSPClientProfile.PHPosCode,
                            PHPreCode = a.LSPClientProfile.PHPreCode,
                            PHProfileClassroom = a.LSPClientProfile.PHProfileClassroom,
                            PHProfileCode = a.LSPClientProfile.PHProfileCode,
                            PHProfileEmail = a.LSPClientProfile.PHProfileEmail,
                            PHProfilefName = a.LSPClientProfile.PHProfilefName,
                            PHProfileNameImg = a.LSPClientProfile.PHProfileNameImg,
                            PHProfileStorageImg = a.LSPClientProfile.PHProfileStorageImg,
                            PHProfileIDcard = a.LSPClientProfile.PHProfileIDcard,
                            PHProfileIDstudent = a.LSPClientProfile.PHProfileIDstudent,
                            PHProfilelName = a.LSPClientProfile.PHProfilelName,
                            PHProfilePhone = a.LSPClientProfile.PHProfilePhone,
                            PHwhenCreate = a.LSPClientProfile.PHwhenCreate,
                            PHwhenEdit = a.LSPClientProfile.PHwhenEdit,
                            PHWhoCreate = a.LSPClientProfile.PHWhoCreate,
                            PHWhoEdit = a.LSPClientProfile.PHWhoEdit,
                            LSPClientDep = b,
                            LSPClientPos = a.LSPClientProfile.LSPClientPos,
                            LSPClientPre = a.LSPClientProfile.LSPClientPre,
                            LSPClientClass = a.LSPClientProfile.LSPClientClass
                        }
                    }).Join(_context.SPClientPosdb,
                    a => a.LSPClientProfile.PHPosCode,
                    b => b.PHPosCode, (a, b) => new SPClientUser
                    {
                        PHProfileCode = a.PHProfileCode,
                        PHUserCode = a.PHUserCode,
                        PHUserName = a.PHUserName,
                        PHUserPassword = a.PHUserPassword,
                        PHUserState = a.PHUserState,
                        PHUserwhenCreate = a.PHUserwhenCreate,
                        PHUserwhenEdit = a.PHUserwhenEdit,
                        PHUserWhoCreate = a.PHUserWhoCreate,
                        LSPClientProfile = new SPClientProfile
                        {
                            PHClassCode = a.LSPClientProfile.PHClassCode,
                            PHDepCode = a.LSPClientProfile.PHDepCode,
                            PHPosCode = a.LSPClientProfile.PHPosCode,
                            PHPreCode = a.LSPClientProfile.PHPreCode,
                            PHProfileClassroom = a.LSPClientProfile.PHProfileClassroom,
                            PHProfileCode = a.LSPClientProfile.PHProfileCode,
                            PHProfileEmail = a.LSPClientProfile.PHProfileEmail,
                            PHProfilefName = a.LSPClientProfile.PHProfilefName,
                            PHProfileIDcard = a.LSPClientProfile.PHProfileIDcard,
                            PHProfileIDstudent = a.LSPClientProfile.PHProfileIDstudent,
                            PHProfileNameImg = a.LSPClientProfile.PHProfileNameImg,
                            PHProfileStorageImg = a.LSPClientProfile.PHProfileStorageImg,
                            PHProfilelName = a.LSPClientProfile.PHProfilelName,
                            PHProfilePhone = a.LSPClientProfile.PHProfilePhone,
                            PHwhenCreate = a.LSPClientProfile.PHwhenCreate,
                            PHwhenEdit = a.LSPClientProfile.PHwhenEdit,
                            PHWhoCreate = a.LSPClientProfile.PHWhoCreate,
                            PHWhoEdit = a.LSPClientProfile.PHWhoEdit,
                            LSPClientDep = a.LSPClientProfile.LSPClientDep,
                            LSPClientPos = b,
                            LSPClientPre = a.LSPClientProfile.LSPClientPre,
                            LSPClientClass = a.LSPClientProfile.LSPClientClass
                        }
                    }).Join(_context.SPClientPredb,
                    a => a.LSPClientProfile.PHPreCode,
                    b => b.PHPreCode, (a, b) => new SPClientUser
                    {
                        PHProfileCode = a.PHProfileCode,
                        PHUserCode = a.PHUserCode,
                        PHUserName = a.PHUserName,
                        PHUserPassword = a.PHUserPassword,
                        PHUserState = a.PHUserState,
                        PHUserwhenCreate = a.PHUserwhenCreate,
                        PHUserwhenEdit = a.PHUserwhenEdit,
                        PHUserWhoCreate = a.PHUserWhoCreate,
                        LSPClientProfile = new SPClientProfile
                        {
                            PHClassCode = a.LSPClientProfile.PHClassCode,
                            PHDepCode = a.LSPClientProfile.PHDepCode,
                            PHPosCode = a.LSPClientProfile.PHPosCode,
                            PHPreCode = a.LSPClientProfile.PHPreCode,
                            PHProfileClassroom = a.LSPClientProfile.PHProfileClassroom,
                            PHProfileCode = a.LSPClientProfile.PHProfileCode,
                            PHProfileEmail = a.LSPClientProfile.PHProfileEmail,
                            PHProfilefName = a.LSPClientProfile.PHProfilefName,
                            PHProfileIDcard = a.LSPClientProfile.PHProfileIDcard,
                            PHProfileIDstudent = a.LSPClientProfile.PHProfileIDstudent,
                            PHProfilelName = a.LSPClientProfile.PHProfilelName,
                            PHProfilePhone = a.LSPClientProfile.PHProfilePhone,
                            PHProfileNameImg = a.LSPClientProfile.PHProfileNameImg,
                            PHProfileStorageImg = a.LSPClientProfile.PHProfileStorageImg,
                            PHwhenCreate = a.LSPClientProfile.PHwhenCreate,
                            PHwhenEdit = a.LSPClientProfile.PHwhenEdit,
                            PHWhoCreate = a.LSPClientProfile.PHWhoCreate,
                            PHWhoEdit = a.LSPClientProfile.PHWhoEdit,
                            LSPClientDep = a.LSPClientProfile.LSPClientDep,
                            LSPClientPos = a.LSPClientProfile.LSPClientPos,
                            LSPClientPre = b,
                            LSPClientClass = a.LSPClientProfile.LSPClientClass
                        }
                    }).ToListAsync();
                return Ok(data);
            }
            return Ok();
        }
        [HttpGet("GetProfile")]
        public async Task<ActionResult<List<SPClientProfile>>> GetDbSPClientProfile()
        {
            if (_context != null)
            {
                var data = await _context.SPClientProfiledb.Join(_context.SPClientClassdb,
                    a => a.PHClassCode,
                    b => b.PHClassCode,
                    (a, b) => new SPClientProfile
                    {
                        PHClassCode = a.PHClassCode,
                        PHDepCode = a.PHDepCode,
                        PHPosCode = a.PHPosCode,
                        PHPreCode = a.PHPreCode,
                        PHProfileClassroom = a.PHProfileClassroom,
                        PHProfileCode = a.PHProfileCode,
                        PHProfileEmail = a.PHProfileEmail,
                        PHProfilefName = a.PHProfilefName,
                        PHProfileIDcard = a.PHProfileIDcard,
                        PHProfileIDstudent = a.PHProfileIDstudent,
                        PHProfileNameImg = a.PHProfileNameImg,
                        PHProfileStorageImg = a.PHProfileStorageImg,
                        PHProfilelName = a.PHProfilelName,
                        PHProfilePhone = a.PHProfilePhone,
                        PHwhenCreate = a.PHwhenCreate,
                        PHwhenEdit = a.PHwhenEdit,
                        PHWhoCreate = a.PHWhoCreate,
                        PHWhoEdit = a.PHWhoEdit,
                        LSPClientDep = a.LSPClientDep,
                        LSPClientPos = a.LSPClientPos,
                        LSPClientPre = a.LSPClientPre,
                        LSPClientClass = b
                    }).Join(_context.SPClientPredb,
                    a => a.PHPreCode,
                    b => b.PHPreCode,
                    (a, b) => new SPClientProfile
                    {
                        PHClassCode = a.PHClassCode,
                        PHDepCode = a.PHDepCode,
                        PHPosCode = a.PHPosCode,
                        PHPreCode = a.PHPreCode,
                        PHProfileClassroom = a.PHProfileClassroom,
                        PHProfileCode = a.PHProfileCode,
                        PHProfileEmail = a.PHProfileEmail,
                        PHProfilefName = a.PHProfilefName,
                        PHProfileIDcard = a.PHProfileIDcard,
                        PHProfileIDstudent = a.PHProfileIDstudent,
                        PHProfileNameImg = a.PHProfileNameImg,
                        PHProfileStorageImg = a.PHProfileStorageImg,
                        PHProfilelName = a.PHProfilelName,
                        PHProfilePhone = a.PHProfilePhone,
                        PHwhenCreate = a.PHwhenCreate,
                        PHwhenEdit = a.PHwhenEdit,
                        PHWhoCreate = a.PHWhoCreate,
                        PHWhoEdit = a.PHWhoEdit,
                        LSPClientDep = a.LSPClientDep,
                        LSPClientPos = a.LSPClientPos,
                        LSPClientPre = b,
                        LSPClientClass = a.LSPClientClass
                    }).Join(_context.SPClientDepdb,
                    a => a.PHDepCode,
                    b => b.PHDepCode,
                    (a, b) => new SPClientProfile
                    {
                        PHClassCode = a.PHClassCode,
                        PHDepCode = a.PHDepCode,
                        PHPosCode = a.PHPosCode,
                        PHPreCode = a.PHPreCode,
                        PHProfileClassroom = a.PHProfileClassroom,
                        PHProfileCode = a.PHProfileCode,
                        PHProfileEmail = a.PHProfileEmail,
                        PHProfilefName = a.PHProfilefName,
                        PHProfileIDcard = a.PHProfileIDcard,
                        PHProfileIDstudent = a.PHProfileIDstudent,
                        PHProfilelName = a.PHProfilelName,
                        PHProfilePhone = a.PHProfilePhone,
                        PHProfileNameImg = a.PHProfileNameImg,
                        PHProfileStorageImg = a.PHProfileStorageImg,
                        PHwhenCreate = a.PHwhenCreate,
                        PHwhenEdit = a.PHwhenEdit,
                        PHWhoCreate = a.PHWhoCreate,
                        PHWhoEdit = a.PHWhoEdit,
                        LSPClientDep = b,
                        LSPClientPos = a.LSPClientPos,
                        LSPClientPre = a.LSPClientPre,
                        LSPClientClass = a.LSPClientClass
                    }).Join(_context.SPClientPosdb,
                    a => a.PHPosCode,
                    b => b.PHPosCode,
                    (a, b) => new SPClientProfile
                    {
                        PHClassCode = a.PHClassCode,
                        PHDepCode = a.PHDepCode,
                        PHPosCode = a.PHPosCode,
                        PHPreCode = a.PHPreCode,
                        PHProfileClassroom = a.PHProfileClassroom,
                        PHProfileCode = a.PHProfileCode,
                        PHProfileEmail = a.PHProfileEmail,
                        PHProfilefName = a.PHProfilefName,
                        PHProfileIDcard = a.PHProfileIDcard,
                        PHProfileIDstudent = a.PHProfileIDstudent,
                        PHProfilelName = a.PHProfilelName,
                        PHProfileNameImg = a.PHProfileNameImg,
                        PHProfileStorageImg = a.PHProfileStorageImg,
                        PHProfilePhone = a.PHProfilePhone,
                        PHwhenCreate = a.PHwhenCreate,
                        PHwhenEdit = a.PHwhenEdit,
                        PHWhoCreate = a.PHWhoCreate,
                        PHWhoEdit = a.PHWhoEdit,
                        LSPClientDep = a.LSPClientDep,
                        LSPClientPos = b,
                        LSPClientPre = a.LSPClientPre,
                        LSPClientClass = a.LSPClientClass
                    }).ToListAsync();
                return Ok(data);
            }
            return Ok();
        }
        [HttpGet("GetClass")]
        public async Task<ActionResult<List<SPClientClass>>> GetDbSPClientClass()
        {
            if (_context != null)
            {
                var data = await _context.SPClientClassdb.ToListAsync();
                return Ok(data);
            }
            return Ok();
        }
        [HttpGet("GetDep")]
        public async Task<ActionResult<List<SPClientDep>>> GetDbSPClientDep()
        {
            if (_context != null)
            {
                var data = await _context.SPClientDepdb.ToListAsync();
                return Ok(data);
            }
            return Ok();
        }
        [HttpGet("GetPre")]
        public async Task<ActionResult<List<SPClientPre>>> GetDbSPClientPre()
        {
            if (_context != null)
            {
                var data = await _context.SPClientPredb.ToListAsync();
                return Ok(data);
            }
            return Ok();
        }
        [HttpGet("GetPos")]
        public async Task<ActionResult<List<SPClientPos>>> GetDbSPClientPos()
        {
            if (_context != null)
            {
                var data = await _context.SPClientPosdb.ToListAsync();
                return Ok(data);
            }
            return Ok();
        }


        /*[HttpPost("PostProfile")]
        public async Task<ActionResult<List<SPClientProfile>>> CreateDbSPClientProfile(SPClientProfile profile)
        {
            if (_context != null)
            {
                var item = _context.SPClientProfiledb?.OrderBy(c => c.PHProfileCode).LastOrDefault();
                var xvAstCode = !string.IsNullOrEmpty(item?.PHProfileCode) ? Int32.Parse(item.PHProfileCode.Split('-')[1]) + 1 : 1;
                var newCode = $"PRO-{xvAstCode.ToString().PadLeft(6, '0')}";
                profile.PHProfileCode = newCode;
                profile.PHwhenCreate = DateTime.Now;
                profile.LSPClientClass = null;
                profile.LSPClientDep = null;
                profile.LSPClientPre = null;
                profile.LSPClientPos = null;

                _context.SPClientProfiledb?.Add(profile);
                await _context.SaveChangesAsync();
            }
            return NoContent();
        }*/
        //[HttpGet("AddressImg")]  
        //public async Task<IActionResult> GetAddressImage(string fileName)
        //{
        //    var uploadResult = await _context.SPClientProfiledb.FirstOrDefaultAsync(u => u.PHProfileStorageImg.Equals(fileName));
        //    var path = Path.Combine(_env.ContentRootPath,"uploads",fileName);
        //    var memory = new MemoryStream();
        //    using (var stream = new FileStream(path, FileMode.Open))
        //    {
        //        await stream.CopyToAsync(memory);
        //    }
        //    memory.Position = 0;
        //    return Ok(path);
        //}

        //[HttpPost("ImageAdd")]
        //public async Task<ActionResult<List<SPClientUser>>> UploadImage(List<IFormFile> files)
        //{
        //    List<SPClientUser> users = new List<SPClientUser>();
        //
        //    foreach(var file in files)
        //    {
        //        var uploadResult = new SPClientUser { LSPClientProfile = new SPClientProfile()};
        //        string trustedFileNameForFileStorage;
        //        var untrustedFileName = file.FileName;
        //        uploadResult.LSPClientProfile.PHProfileNameImg = untrustedFileName;
        //        //var trustedFileNameForDisplay = WebUtility.HtmlEncode(untrustedFileName);
        //
        //        trustedFileNameForFileStorage = Path.GetRandomFileName();
        //        var path = Path.Combine(_env.ContentRootPath,"wwwroot/uploads",trustedFileNameForFileStorage);
        //
        //        await using FileStream fs = new(path, FileMode.Create);
        //        await file.CopyToAsync(fs);
        //        uploadResult.LSPClientProfile.PHProfileStorageImg = trustedFileNameForFileStorage;
        //        users.Add(uploadResult);
        //    }return Ok(users);
        //}
        [HttpPost("PostUser")]
        public async Task<ActionResult<List<SPClientUser>>> CreatePrf(SPClientUser member)
        {

            if (_context != null)
            {
                var item = _context.SPClientProfiledb?.OrderBy(c => c.PHProfileCode).LastOrDefault();
                var itemUser = _context.SPClientUserdb?.OrderBy(c => c.PHUserCode).LastOrDefault();
                var xVPrfCode = !string.IsNullOrEmpty(item?.PHProfileCode) ? Int32.Parse(item.PHProfileCode.Split('-')[1]) + 1 : 1;
                var xvUserCode = !string.IsNullOrEmpty(itemUser?.PHUserCode) ? Int32.Parse(itemUser.PHUserCode.Split('-')[1]) + 1 : 1;

                var newCode = $"PRO-{xVPrfCode.ToString().PadLeft(6, '0')}";
                var newCodeUser = $"USE-{xvUserCode.ToString().PadLeft(6, '0')}";

                //  prf.XVPrfCode = newCode;
                member.PHUserCode = newCodeUser;
                member.PHUserwhenCreate= DateTime.Now;
                member.PHUserwhenEdit = null;
                if (member.LSPClientProfile != null)
                {
                    if(member.LSPClientProfile.PHClassCode != null && member.LSPClientProfile.PHDepCode != null)
                    {
                        member.LSPClientProfile.PHClassCode = "CL-000001";
                        member.LSPClientProfile.PHDepCode = "DEP-000001";
                    }
                    member.LSPClientProfile.PHProfileCode = newCode;
                    member.LSPClientProfile.PHwhenCreate = DateTime.Now;
                    member.LSPClientProfile.PHwhenEdit= null ;

                    member.LSPClientProfile.LSPClientClass = null;
                    member.LSPClientProfile.LSPClientDep = null;
                    member.LSPClientProfile.LSPClientPos = null;
                    member.LSPClientProfile.LSPClientPre = null;
                }

                _context.SPClientUserdb?.Add(member);
                await _context.SaveChangesAsync();
            }
            return Ok(await GetSPClientUser());
        }
        [HttpPost("PostClass")]
        public async Task<ActionResult<List<SPClientClass>>> CreateDbSPClientClass(SPClientClass cla)
        {
            if (_context != null)
            {
                var item = _context.SPClientClassdb?.OrderBy(c => c.PHClassCode).LastOrDefault();
                var xvAstCode = !string.IsNullOrEmpty(item?.PHClassCode) ? Int32.Parse(item.PHClassCode.Split('-')[1]) + 1 : 1;
                var newCode = $"CL-{xvAstCode.ToString().PadLeft(6, '0')}";
                cla.PHClassCode = newCode;

                _context.SPClientClassdb?.Add(cla);
                await _context.SaveChangesAsync();
            }
            return NoContent();
        }
        [HttpPost("PostDep")]
        public async Task<ActionResult<List<SPClientDep>>> CreateDbSPClientDep(SPClientDep dep)
        {
            if (_context != null)
            {
                var item = _context.SPClientDepdb?.OrderBy(c => c.PHDepCode).LastOrDefault();
                var xvAstCode = !string.IsNullOrEmpty(item?.PHDepCode) ? Int32.Parse(item.PHDepCode.Split('-')[1]) + 1 : 1;
                var newCode = $"DEP-{xvAstCode.ToString().PadLeft(6, '0')}";
                dep.PHDepCode = newCode;

                _context.SPClientDepdb?.Add(dep);
                await _context.SaveChangesAsync();
            }
            return NoContent();
        }
        [HttpPost("PostPre")]
        public async Task<ActionResult<List<SPClientPre>>> CreateDbSPClientPre(SPClientPre pre)
        {
            if (_context != null)
            {
                var item = _context.SPClientPredb?.OrderBy(c => c.PHPreCode).LastOrDefault();
                var xvAstCode = !string.IsNullOrEmpty(item?.PHPreCode) ? Int32.Parse(item.PHPreCode.Split('-')[1]) + 1 : 1;
                var newCode = $"PRE-{xvAstCode.ToString().PadLeft(6, '0')}";
                pre.PHPreCode = newCode;

                _context.SPClientPredb?.Add(pre);
                await _context.SaveChangesAsync();
            }
            return NoContent();
        }
        [HttpPost("PostPos")]
        public async Task<ActionResult<List<SPClientPos>>> CreateDbSPClientPos(SPClientPos pos)
        {
            if (_context != null)
            {
                var item = _context.SPClientPosdb?.OrderBy(c => c.PHPosCode).LastOrDefault();
                var xvAstCode = !string.IsNullOrEmpty(item?.PHPosCode) ? Int32.Parse(item.PHPosCode .Split('-')[1]) + 1 : 1;
                var newCode = $"POS-{xvAstCode.ToString().PadLeft(6, '0')}";
                pos.PHPosCode = newCode;

                _context.SPClientPosdb?.Add(pos);
                await _context.SaveChangesAsync();
            }
            return Ok(await GetSPClientPos());
        }


        [HttpPut("PutUser")]
        public async Task<ActionResult> UpdateDbSPClientUser(string id, [FromBody] SPClientUser member)
        {
            var data = await _context.SPClientUserdb.Include(d => d.LSPClientProfile).FirstOrDefaultAsync(a => a.PHUserCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHUserName = member.PHUserName;
            data.PHUserPassword = member.PHUserPassword;
            data.PHUserwhenEdit = DateTime.Now;
            data.PHUserState = member.PHUserState;
            if (data.LSPClientProfile != null && member.LSPClientProfile != null)
            {
                data.LSPClientProfile.PHwhenEdit = DateTime.Now;
                data.LSPClientProfile.PHProfileEmail = member.LSPClientProfile.PHProfileEmail;
                data.LSPClientProfile.PHProfilePhone = member.LSPClientProfile.PHProfilePhone;
                data.LSPClientProfile.PHProfileIDcard = member.LSPClientProfile.PHProfileIDcard;
                data.LSPClientProfile.PHProfileIDstudent = member.LSPClientProfile.PHProfileIDstudent;
                data.LSPClientProfile.PHProfileClassroom = member.LSPClientProfile.PHProfileClassroom;
                data.LSPClientProfile.PHClassCode = member.LSPClientProfile.PHClassCode;
                data.LSPClientProfile.PHDepCode = member.LSPClientProfile.PHDepCode;
                data.LSPClientProfile.PHPosCode = member.LSPClientProfile.PHPosCode;
                data.LSPClientProfile.PHPreCode = member.LSPClientProfile.PHPreCode;
                data.LSPClientProfile.PHProfileNameImg = member.LSPClientProfile.PHProfileNameImg;
                data.LSPClientProfile.PHProfileStorageImg = member.LSPClientProfile.PHProfileStorageImg;
                data.LSPClientProfile.PHProfilefName = member.LSPClientProfile.PHProfilefName;
                data.LSPClientProfile.PHProfilelName = member.LSPClientProfile.PHProfilelName;
            }
            await _context.SaveChangesAsync();

            return Ok(await GetSPClientUser());
        }
        [HttpPut("PutClass")]
        public async Task<ActionResult> UpdateDbSPClientClass(string id, [FromBody] SPClientClass cla)
        {
            var data = await _context.SPClientClassdb.SingleOrDefaultAsync(a => a.PHClassCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHClassName = cla.PHClassName;
            await _context.SaveChangesAsync();

            return Ok(await GetSPClientClass());
        }
        [HttpPut("PutDep")]
        public async Task<ActionResult> UpdateDbSPClientDep(string id, [FromBody] SPClientDep dep)
        {
            var data = await _context.SPClientDepdb.SingleOrDefaultAsync(a => a.PHDepCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHDepName = dep.PHDepName;
            await _context.SaveChangesAsync();

            return Ok(await GetSPClientDep());
        }
        [HttpPut("PutPre")]
        public async Task<ActionResult> UpdateDbSPClientPre(string id, [FromBody] SPClientPre pre)
        {
            var data = await _context.SPClientPredb.SingleOrDefaultAsync(a => a.PHPreCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHPreName = pre.PHPreName;
            await _context.SaveChangesAsync();

            return Ok(await GetSPClientPre());
        }
        [HttpPut("PutPos")]
        public async Task<ActionResult> UpdateDbSPClientPos(string id, [FromBody] SPClientPos pos)
        {
            var data = await _context.SPClientPosdb.SingleOrDefaultAsync(a => a.PHPosCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHPosName = pos.PHPosName;
            await _context.SaveChangesAsync();

            return Ok(await GetSPClientPos());
        }


        [HttpDelete("DelUser")]
        public async Task<ActionResult<List<SPClientUser>>> DeleteDbSPClientUser([FromQuery] string idu,[FromQuery] string idp)
        {
            var data = await _context.SPClientUserdb
                .FirstOrDefaultAsync(sh => sh.PHUserCode == idu);
            if (data == null)
                return NotFound("Sorry, but no hero for you. :/");

            var dataPrf = await _context.SPClientProfiledb 
                .FirstOrDefaultAsync(sh => sh.PHProfileCode == idp);
            if (dataPrf == null)
                return NotFound("Sorry, but no hero for you. :/");

            _context.SPClientUserdb.Remove(data);
            _context.SPClientProfiledb.Remove(dataPrf);

            await _context.SaveChangesAsync();
            return Ok(await GetSPClientUser());
        }
        [HttpDelete("DelClass")]
        public async Task<ActionResult<List<SPClientClass>>> DeleteDbSPClientClass([FromQuery] string id)
        {
            var data = await _context.SPClientClassdb
                .FirstOrDefaultAsync(sh => sh.PHClassCode == id);
            if (data == null)
                return NotFound("Sorry, but no hero for you. :/");

            _context.SPClientClassdb.Remove(data);
            await _context.SaveChangesAsync();
            return Ok(await GetSPClientClass());
        }
        [HttpDelete("DelDep")]
        public async Task<ActionResult<List<SPClientDep>>> DeleteDbSPClientDep([FromQuery] string id)
        {
            var data = await _context.SPClientDepdb
                .FirstOrDefaultAsync(sh => sh.PHDepCode == id);
            if (data == null)
                return NotFound("Sorry, but no hero for you. :/");

            _context.SPClientDepdb.Remove(data);
            await _context.SaveChangesAsync();
            return Ok(await GetSPClientDep());
        }
        [HttpDelete("DelPre")]
        public async Task<ActionResult<List<SPClientPre>>> DeleteDbSPClientPre([FromQuery] string id)
        {
            var data = await _context.SPClientPredb
                .FirstOrDefaultAsync(sh => sh.PHPreCode == id);
            if (data == null)
                return NotFound("Sorry, but no hero for you. :/");

            _context.SPClientPredb.Remove(data);
            await _context.SaveChangesAsync();
            return Ok(await GetSPClientPre());
        }
        [HttpDelete("DelPos")]
        public async Task<ActionResult<List<SPClientPos>>> DeleteDbSPClientPos([FromQuery] string id)
        {
            var data = await _context.SPClientPosdb
                .FirstOrDefaultAsync(sh => sh.PHPosCode == id);
            if (data == null)
                return NotFound("Sorry, but no hero for you. :/");

            _context.SPClientPosdb.Remove(data);
            await _context.SaveChangesAsync();
            return Ok(await GetSPClientPos());
        }


        private async Task<List<SPClientUser>> GetSPClientUser()
        {
            return await _context.SPClientUserdb.Include(sh => sh.LSPClientProfile).Join(_context.SPClientClassdb,
                    a => a.LSPClientProfile.PHClassCode,
                    b => b.PHClassCode, (a, b) => new SPClientUser
                    {
                        PHProfileCode = a.PHProfileCode,
                        PHUserCode = a.PHUserCode,
                        PHUserName = a.PHUserName,
                        PHUserPassword = a.PHUserPassword,
                        PHUserState = a.PHUserState,
                        PHUserwhenCreate = a.PHUserwhenCreate,
                        PHUserwhenEdit = a.PHUserwhenEdit,
                        PHUserWhoCreate = a.PHUserWhoCreate,
                        LSPClientProfile = new SPClientProfile
                        {
                            PHClassCode = a.LSPClientProfile.PHClassCode,
                            PHDepCode = a.LSPClientProfile.PHDepCode,
                            PHPosCode = a.LSPClientProfile.PHPosCode,
                            PHPreCode = a.LSPClientProfile.PHPreCode,
                            PHProfileClassroom = a.LSPClientProfile.PHProfileClassroom,
                            PHProfileCode = a.LSPClientProfile.PHProfileCode,
                            PHProfileEmail = a.LSPClientProfile.PHProfileEmail,
                            PHProfileNameImg = a.LSPClientProfile.PHProfileNameImg,
                            PHProfileStorageImg = a.LSPClientProfile.PHProfileStorageImg,
                            PHProfilefName = a.LSPClientProfile.PHProfilefName,
                            PHProfileIDcard = a.LSPClientProfile.PHProfileIDcard,
                            PHProfileIDstudent = a.LSPClientProfile.PHProfileIDstudent,
                            PHProfilelName = a.LSPClientProfile.PHProfilelName,
                            PHProfilePhone = a.LSPClientProfile.PHProfilePhone,
                            PHwhenCreate = a.LSPClientProfile.PHwhenCreate,
                            PHwhenEdit = a.LSPClientProfile.PHwhenEdit,
                            PHWhoCreate = a.LSPClientProfile.PHWhoCreate,
                            PHWhoEdit = a.LSPClientProfile.PHWhoEdit,
                            LSPClientDep = a.LSPClientProfile.LSPClientDep,
                            LSPClientPos = a.LSPClientProfile.LSPClientPos,
                            LSPClientPre = a.LSPClientProfile.LSPClientPre,
                            LSPClientClass = b
                        }
                    }).Join(_context.SPClientDepdb,
                    a => a.LSPClientProfile.PHDepCode,
                    b => b.PHDepCode, (a, b) => new SPClientUser
                    {
                        PHProfileCode = a.PHProfileCode,
                        PHUserCode = a.PHUserCode,
                        PHUserName = a.PHUserName,
                        PHUserPassword = a.PHUserPassword,
                        PHUserState = a.PHUserState,
                        PHUserwhenCreate = a.PHUserwhenCreate,
                        PHUserwhenEdit = a.PHUserwhenEdit,
                        PHUserWhoCreate = a.PHUserWhoCreate,
                        LSPClientProfile = new SPClientProfile
                        {
                            PHClassCode = a.LSPClientProfile.PHClassCode,
                            PHDepCode = a.LSPClientProfile.PHDepCode,
                            PHPosCode = a.LSPClientProfile.PHPosCode,
                            PHPreCode = a.LSPClientProfile.PHPreCode,
                            PHProfileClassroom = a.LSPClientProfile.PHProfileClassroom,
                            PHProfileCode = a.LSPClientProfile.PHProfileCode,
                            PHProfileEmail = a.LSPClientProfile.PHProfileEmail,
                            PHProfilefName = a.LSPClientProfile.PHProfilefName,
                            PHProfileNameImg = a.LSPClientProfile.PHProfileNameImg,
                            PHProfileStorageImg = a.LSPClientProfile.PHProfileStorageImg,
                            PHProfileIDcard = a.LSPClientProfile.PHProfileIDcard,
                            PHProfileIDstudent = a.LSPClientProfile.PHProfileIDstudent,
                            PHProfilelName = a.LSPClientProfile.PHProfilelName,
                            PHProfilePhone = a.LSPClientProfile.PHProfilePhone,
                            PHwhenCreate = a.LSPClientProfile.PHwhenCreate,
                            PHwhenEdit = a.LSPClientProfile.PHwhenEdit,
                            PHWhoCreate = a.LSPClientProfile.PHWhoCreate,
                            PHWhoEdit = a.LSPClientProfile.PHWhoEdit,
                            LSPClientDep = b,
                            LSPClientPos = a.LSPClientProfile.LSPClientPos,
                            LSPClientPre = a.LSPClientProfile.LSPClientPre,
                            LSPClientClass = a.LSPClientProfile.LSPClientClass
                        }
                    }).Join(_context.SPClientPosdb,
                    a => a.LSPClientProfile.PHPosCode,
                    b => b.PHPosCode, (a, b) => new SPClientUser
                    {
                        PHProfileCode = a.PHProfileCode,
                        PHUserCode = a.PHUserCode,
                        PHUserName = a.PHUserName,
                        PHUserPassword = a.PHUserPassword,
                        PHUserState = a.PHUserState,
                        PHUserwhenCreate = a.PHUserwhenCreate,
                        PHUserwhenEdit = a.PHUserwhenEdit,
                        PHUserWhoCreate = a.PHUserWhoCreate,
                        LSPClientProfile = new SPClientProfile
                        {
                            PHClassCode = a.LSPClientProfile.PHClassCode,
                            PHDepCode = a.LSPClientProfile.PHDepCode,
                            PHPosCode = a.LSPClientProfile.PHPosCode,
                            PHPreCode = a.LSPClientProfile.PHPreCode,
                            PHProfileClassroom = a.LSPClientProfile.PHProfileClassroom,
                            PHProfileCode = a.LSPClientProfile.PHProfileCode,
                            PHProfileEmail = a.LSPClientProfile.PHProfileEmail,
                            PHProfilefName = a.LSPClientProfile.PHProfilefName,
                            PHProfileIDcard = a.LSPClientProfile.PHProfileIDcard,
                            PHProfileIDstudent = a.LSPClientProfile.PHProfileIDstudent,
                            PHProfileNameImg = a.LSPClientProfile.PHProfileNameImg,
                            PHProfileStorageImg = a.LSPClientProfile.PHProfileStorageImg,
                            PHProfilelName = a.LSPClientProfile.PHProfilelName,
                            PHProfilePhone = a.LSPClientProfile.PHProfilePhone,
                            PHwhenCreate = a.LSPClientProfile.PHwhenCreate,
                            PHwhenEdit = a.LSPClientProfile.PHwhenEdit,
                            PHWhoCreate = a.LSPClientProfile.PHWhoCreate,
                            PHWhoEdit = a.LSPClientProfile.PHWhoEdit,
                            LSPClientDep = a.LSPClientProfile.LSPClientDep,
                            LSPClientPos = b,
                            LSPClientPre = a.LSPClientProfile.LSPClientPre,
                            LSPClientClass = a.LSPClientProfile.LSPClientClass
                        }
                    }).Join(_context.SPClientPredb,
                    a => a.LSPClientProfile.PHPreCode,
                    b => b.PHPreCode, (a, b) => new SPClientUser
                    {
                        PHProfileCode = a.PHProfileCode,
                        PHUserCode = a.PHUserCode,
                        PHUserName = a.PHUserName,
                        PHUserPassword = a.PHUserPassword,
                        PHUserState = a.PHUserState,
                        PHUserwhenCreate = a.PHUserwhenCreate,
                        PHUserwhenEdit = a.PHUserwhenEdit,
                        PHUserWhoCreate = a.PHUserWhoCreate,
                        LSPClientProfile = new SPClientProfile
                        {
                            PHClassCode = a.LSPClientProfile.PHClassCode,
                            PHDepCode = a.LSPClientProfile.PHDepCode,
                            PHPosCode = a.LSPClientProfile.PHPosCode,
                            PHPreCode = a.LSPClientProfile.PHPreCode,
                            PHProfileClassroom = a.LSPClientProfile.PHProfileClassroom,
                            PHProfileCode = a.LSPClientProfile.PHProfileCode,
                            PHProfileEmail = a.LSPClientProfile.PHProfileEmail,
                            PHProfilefName = a.LSPClientProfile.PHProfilefName,
                            PHProfileIDcard = a.LSPClientProfile.PHProfileIDcard,
                            PHProfileIDstudent = a.LSPClientProfile.PHProfileIDstudent,
                            PHProfilelName = a.LSPClientProfile.PHProfilelName,
                            PHProfilePhone = a.LSPClientProfile.PHProfilePhone,
                            PHProfileNameImg = a.LSPClientProfile.PHProfileNameImg,
                            PHProfileStorageImg = a.LSPClientProfile.PHProfileStorageImg,
                            PHwhenCreate = a.LSPClientProfile.PHwhenCreate,
                            PHwhenEdit = a.LSPClientProfile.PHwhenEdit,
                            PHWhoCreate = a.LSPClientProfile.PHWhoCreate,
                            PHWhoEdit = a.LSPClientProfile.PHWhoEdit,
                            LSPClientDep = a.LSPClientProfile.LSPClientDep,
                            LSPClientPos = a.LSPClientProfile.LSPClientPos,
                            LSPClientPre = b,
                            LSPClientClass = a.LSPClientProfile.LSPClientClass
                        }
                    }).ToListAsync();
        }
        private async Task<List<SPClientClass>> GetSPClientClass()
        {
            return await _context.SPClientClassdb.ToListAsync();
        }
        private async Task<List<SPClientDep>> GetSPClientDep()
        {
            return await _context.SPClientDepdb.ToListAsync();
        }
        private async Task<List<SPClientPre>> GetSPClientPre()
        {
            return await _context.SPClientPredb.ToListAsync();
        }
        private async Task<List<SPClientPos>> GetSPClientPos()
        {
            return await _context.SPClientPosdb.ToListAsync();
        }



        [HttpGet("GetSport")]
        public async Task<ActionResult<List<SPModelSport>>> GetDbSPModelSport()
        {
            if (_context != null)
            {
                var data = await _context.SPModelSportdb.ToListAsync();
                return Ok(data);
            }
            return Ok();
        }
        [HttpGet("GetEquip")]
        public async Task<ActionResult<List<SPModelEquip>>> GetDbSPModelEquip()
        {
            if (_context != null)
            {
                var data = await _context.SPModelEquipdb.Join(_context.SPModelSportdb,
                    a => a.PHSportCode,
                    b => b.PHSportCode,
                    (a, b) => new SPModelEquip
                    { 
                        PHEquipCode = a.PHEquipCode,
                        PHSportCode = a.PHSportCode,
                        PHEquipAmount = a.PHEquipAmount,
                        PHEquipImg = a.PHEquipImg,
                        PHEquipName = a.PHEquipName,
                        PHEquipStatus = a.PHEquipStatus,
                        PHEquipTotal = a.PHEquipTotal,
                        PHEquipBorroww = a.PHEquipBorroww,
                        PHEquipLost = a.PHEquipLost,
                        PHEquipBroken = a.PHEquipBroken,
                        PHEquipUnit = a.PHEquipUnit,
                        PHEquipwhenCreate = a.PHEquipwhenCreate,
                        PHEquipwhenEdit = a.PHEquipwhenEdit,
                        LSPModelSport = b
                    }).ToListAsync();
                return Ok(data);
            }
            return Ok();
        }


        [HttpPost("PostSport")]
        public async Task<ActionResult<List<SPModelSport>>> CreateDbSPModelSport(SPModelSport sport)
        {
            if (_context != null)
            {
                var item = _context.SPModelSportdb?.OrderBy(c => c.PHSportCode).LastOrDefault();
                var sportCode = !string.IsNullOrEmpty(item?.PHSportCode) ? Int32.Parse(item.PHSportCode.Split('-')[1]) + 1 : 1;
                var newCode = $"SPO-{sportCode.ToString().PadLeft(6, '0')}";
                sport.PHSportCode = newCode;

                _context.SPModelSportdb?.Add(sport);
                await _context.SaveChangesAsync();
            }
            return NoContent();
        }
        [HttpPost("PostEquip")]
        public async Task<ActionResult<List<SPModelEquip>>> CreateDbSPModelEquip(SPModelEquip equip)
        {
            if (_context != null)
            {
                var item = _context.SPModelEquipdb?.OrderBy(c => c.PHEquipCode).LastOrDefault();
                var xvAstCode = !string.IsNullOrEmpty(item?.PHEquipCode) ? Int32.Parse(item.PHEquipCode.Split('-')[1]) + 1 : 1;
                var newCode = $"EQU-{xvAstCode.ToString().PadLeft(6, '0')}";
                equip.PHEquipCode = newCode;
                equip.PHEquipwhenCreate = DateTime.Now;
                equip.PHEquipBorroww = 0;
                equip.PHEquipLost = 0;
                equip.PHEquipBroken = 0;
                equip.PHEquipTotal = equip.PHEquipAmount - equip.PHEquipBorroww - equip.PHEquipBroken - equip.PHEquipLost;
                equip.LSPModelSport = null;

                _context.SPModelEquipdb?.Add(equip);
                await _context.SaveChangesAsync();
            }
            return NoContent();
        }


        [HttpPut("PutSport")]
        public async Task<ActionResult> UpdateDbSPModelSport(string id, [FromBody] SPModelSport sport)
        {
            var data = await _context.SPModelSportdb.SingleOrDefaultAsync(a => a.PHSportCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHSportName = sport.PHSportName;
            await _context.SaveChangesAsync();

            return Ok(await GetSPModelSport());
        }
        [HttpPut("PutEquip")]
        public async Task<ActionResult> UpdateDbSPModelEquip(string id, [FromBody] SPModelEquip equip)
        {
            var data = await _context.SPModelEquipdb.SingleOrDefaultAsync(a => a.PHEquipCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHEquipName = equip.PHEquipName;
            data.PHEquipImg = equip.PHEquipImg;
            data.PHEquipAmount = equip.PHEquipAmount;
            data.PHEquipTotal = equip.PHEquipAmount - data.PHEquipBorroww - equip.PHEquipBroken - equip.PHEquipLost;
            data.PHEquipStatus = equip.PHEquipStatus;
            data.PHEquipLost = equip.PHEquipLost;   
            data.PHEquipBroken = equip.PHEquipBroken;
            data.PHEquipUnit = equip.PHEquipUnit;   
            data.PHSportCode = equip.PHSportCode; 
            data.PHEquipwhenEdit = DateTime.Now;
                data.PHEquipImg = equip.PHEquipImg;

            await _context.SaveChangesAsync();

            return Ok(await GetSPModelEquip());
        }

        [HttpPut("PutEquipTwo")]
        public async Task<ActionResult> BorrowDbSPModelEquip(string id, [FromBody] SPModelEquip equip)
        {
            var data = await _context.SPModelEquipdb.SingleOrDefaultAsync(a => a.PHEquipCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHEquipBorroww += equip.PHEquipBorroww;
            data.PHEquipTotal -=equip.PHEquipBorroww;
            await _context.SaveChangesAsync();

            return Ok(await GetSPModelEquip());
        }
        [HttpPut("PutEquipThree")]
        public async Task<ActionResult> ReturnDbSPModelEquip(string id, [FromBody] SPModelEquip equip)
        {
            var data = await _context.SPModelEquipdb.SingleOrDefaultAsync(a => a.PHEquipCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHEquipLost += equip.PHEquipLost;
            data.PHEquipBroken += equip.PHEquipBroken;
            data.PHEquipBorroww -= equip.PHEquipBorroww;
            data.PHEquipTotal = data.PHEquipTotal - equip.PHEquipLost - equip.PHEquipBroken + equip.PHEquipBorroww;
            await _context.SaveChangesAsync();

            return Ok(await GetSPModelEquip());
        }

        [HttpDelete("DelSport")]
        public async Task<ActionResult<List<SPModelSport>>> DeleteDbSPModelSport([FromQuery] string id)
        {
            var data = await _context.SPModelSportdb
                .FirstOrDefaultAsync(sh => sh.PHSportCode == id);
            if (data == null)
                return NotFound("Sorry, but no hero for you. :/");

            _context.SPModelSportdb.Remove(data);
            await _context.SaveChangesAsync();
            return Ok(await GetSPModelSport());
        }
        [HttpDelete("DelEquip")]
        public async Task<ActionResult<List<SPModelEquip>>> DeleteDbSPModelEquip([FromQuery] string id)
        {
            var data = await _context.SPModelEquipdb
                .FirstOrDefaultAsync(sh => sh.PHEquipCode == id);
            if (data == null)
                return NotFound("Sorry, but no hero for you. :/");

            _context.SPModelEquipdb.Remove(data);
            await _context.SaveChangesAsync();
            return Ok(await GetSPModelEquip());
        }

        private async Task<List<SPModelSport>> GetSPModelSport()
        {
            return await _context.SPModelSportdb.ToListAsync();
        }
        private async Task<List<SPModelEquip>> GetSPModelEquip()
        {
            return await _context.SPModelEquipdb.Join(_context.SPModelSportdb,
                    a => a.PHSportCode,
                    b => b.PHSportCode,
                    (a, b) => new SPModelEquip
                    {
                        PHEquipCode = a.PHEquipCode,
                        PHSportCode = a.PHSportCode,
                        PHEquipAmount = a.PHEquipAmount,
                        PHEquipImg = a.PHEquipImg,
                        PHEquipName = a.PHEquipName,
                        PHEquipBorroww = a.PHEquipBorroww,
                        PHEquipLost = a.PHEquipLost,
                        PHEquipBroken = a.PHEquipBroken,
                        PHEquipStatus = a.PHEquipStatus,
                        PHEquipTotal = a.PHEquipTotal,
                        PHEquipUnit = a.PHEquipUnit,
                        PHEquipwhenCreate = a.PHEquipwhenCreate,
                        PHEquipwhenEdit = a.PHEquipwhenEdit,
                        LSPModelSport = b
                    }).ToListAsync();
        }



        [HttpGet("GetHis")]
        public async Task<ActionResult<List<SPHisAction>>> GetDbSPHisAction()
        {
            if (_context != null)
            {
                var data = await _context.SPHisActiondb.ToListAsync();
                return Ok(data);
            }
            return Ok();
        }

        [HttpPost("PostHis")]
        public async Task<ActionResult<List<SPHisAction>>> CreateDbSPHisAction(SPHisAction His)
        {
            if (_context != null)
            {
                var item = _context.SPHisActiondb?.OrderBy(c => c.PHHisActionCode).LastOrDefault();
                var sportCode = !string.IsNullOrEmpty(item?.PHHisActionCode) ? Int32.Parse(item.PHHisActionCode.Split('-')[1]) + 1 : 1;
                var newCode = $"HIS-{sportCode.ToString().PadLeft(8, '0')}";
                His.PHHisActionCode = newCode;
                His.PHborrow = DateTime.Now;

                _context.SPHisActiondb?.Add(His);
                await _context.SaveChangesAsync();
            }
            return Ok(await GetSPHisAction());
        }
        [HttpPut("PutHis")]
        public async Task<ActionResult> TurnDbSPModelEquip(string id, [FromBody] SPHisAction His)
        {
            var data = await _context.SPHisActiondb.SingleOrDefaultAsync(a => a.PHHisActionCode == id);
            if (data == null)
                return NotFound("ไม่พบข้อมูล");

            data.PHreturn = DateTime.Now;
            data.PHequipReturn = His.PHequipReturn;
            await _context.SaveChangesAsync();

            return Ok(await GetSPHisAction());
        }
        private async Task<List<SPHisAction>> GetSPHisAction()
        {
            return await _context.SPHisActiondb.ToListAsync();
        }


    }
}
