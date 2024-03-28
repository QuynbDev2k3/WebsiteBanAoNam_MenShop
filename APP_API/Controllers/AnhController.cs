using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers;

<<<<<<< HEAD
[Route("api/[controller]")]

[ApiController]
public class AnhController : ControllerBase
{
    private readonly IAnhServices anh;

    public AnhController(IAnhServices anhser)
=======
[Route("api/nhanvien")]
[ApiController]
public class AnhController : ControllerBase
{
    private readonly IAnhServiece anh;

    public AnhController(IAnhServiece anhser)
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
    {
        this.anh = anhser;
    }

    [Route("getall")]
    [HttpGet]
    public async Task<IActionResult> GetAllAnh()
    {
        var result = await this.anh.GetAll();
        return Ok(result);
    }

    [Route("getbyid/{id}")]
    [HttpGet]
    public async Task<IActionResult> GetAnhById(Guid id)
    {
        var result = await this.anh.GetById(id);
        return Ok(result);
    }

    [Route("add")]
    [HttpPost]
<<<<<<< HEAD
    public async Task<IActionResult> AddAnh([FromQuery]string linkanh, bool trangthai,Guid idctSP)
    {
        await this.anh.Create(linkanh, trangthai);
        return Created("", new { IdCtSanPham = idctSP, LinkAnh = linkanh, TrangThai = trangthai });
=======
    public async Task<IActionResult> AddAnh([FromQuery] string linkanh, bool trangthai)
    {
        await this.anh.Add(linkanh, trangthai);
        return Created("", new { LinkAnh = linkanh, TrangThai = trangthai });
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
    }

    [Route("update/{id}")]
    [HttpPut]
    public async Task<IActionResult> UpdateAnh(Guid id, string linkanh, bool trangthai)
    {
<<<<<<< HEAD
        await this.anh.Update(id, linkanh, trangthai);
=======
        await this.anh.Edit(id, linkanh, trangthai);
>>>>>>> 932235a6a3db4ad035f87a6d85d51d4aee12f9cd
        return Created("", new { Id = id, LinkAnh = linkanh, TrangThai = trangthai });
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteAnh(Guid id)
    {
        await this.anh.Delete(id);
        return Ok();
    }
}