using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers;

[Route("api/hang")]
[ApiController]
public class HangController : ControllerBase
{
    private readonly IHangService hangService;

    public HangController(IHangService hangService)
    {
        this.hangService = hangService;
    }

    [Route("getall")]
    [HttpGet]
    public async Task<IActionResult> GetAllHang()
    {
        var result = await this.hangService.GetAll();
        return Ok(result);
    }

    [Route("getbyid/{id}")]
    [HttpGet]
    public async Task<IActionResult> GetHangById(Guid id)
    {
        var result = await this.hangService.GetById(id);
        return Ok(result);
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> AddHang(string ten, bool trangthai)
    {
        await this.hangService.Create(ten, trangthai);
        return Created("", new { Ten = ten, TrangThai = trangthai });
    }

    [Route("update/{id}")]
    [HttpPut]
    public async Task<IActionResult> UpdateHang(Guid id, string ten, bool trangthai)
    {
        await this.hangService.Update(id, ten, trangthai);
        return Created("", new {Id = id, Ten = ten, TrangThai = trangthai });
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteHang(Guid id)
    {
        await this.hangService.Delete(id);
        return Ok();
    }
}