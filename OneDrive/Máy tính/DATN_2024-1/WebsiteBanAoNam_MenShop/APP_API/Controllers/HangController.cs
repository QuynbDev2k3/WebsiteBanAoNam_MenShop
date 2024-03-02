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
    public async Task<IActionResult> AddHang(Hang hang)
    {
        await this.hangService.Create(hang);
        return Created("", hang);
    }

    [Route("update")]
    [HttpPut]
    public async Task<IActionResult> UpdateHang(Hang hang)
    {
        await this.hangService.Update(hang);
        return Ok(hang);
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteHang(Guid id)
    {
        await this.hangService.Delete(id);
        return Ok();
    }
}