using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnhController : ControllerBase
{
    private readonly IAnhServiece anh;

    public AnhController(IAnhServiece anhser)
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
    public async Task<IActionResult> AddAnh([FromQuery] string linkanh, bool trangthai, Guid idctSP)
    {
        await this.anh.Add(linkanh, trangthai);
        return Created("", new { IdCtSanPham = idctSP, LinkAnh = linkanh, TrangThai = trangthai });
    }
    public async Task<IActionResult> AddAnh([FromQuery] string linkanh, bool trangthai)
    {
        await this.anh.Add(linkanh, trangthai);
        return Created("", new { LinkAnh = linkanh, TrangThai = trangthai });
    }

    [Route("update/{id}")]
    [HttpPut]
    public async Task<IActionResult> UpdateAnh(Guid id, string linkanh, bool trangthai)
    {
        await this.anh.Edit(id, linkanh, trangthai);
        await this.anh.Edit(id, linkanh, trangthai);
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