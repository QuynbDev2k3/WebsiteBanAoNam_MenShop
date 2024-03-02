using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers;

[Route("api/ctsanpham")]
[ApiController]
public class CTSanPhamController : ControllerBase
{
    private readonly ICTSanPhamService ctSanPhamService;

    public CTSanPhamController(ICTSanPhamService ctSanPhamService)
    {
        this.ctSanPhamService = ctSanPhamService;
    }

    [Route("getall")]
    [HttpGet]
    public async Task<IActionResult> GetAllCTSanPham()
    {
        var result = await this.ctSanPhamService.GetAll();
        return Ok(result);
    }

    [Route("getbyid/{id}")]
    [HttpGet]
    public async Task<IActionResult> GetCTSanPhamById(Guid id)
    {
        var result = await this.ctSanPhamService.GetById(id);
        return Ok(result);
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> AddCTSanPham(CTSanPham ctSanPham)
    {
        await this.ctSanPhamService.Create(ctSanPham);
        return Created("", ctSanPham);
    }

    [Route("update")]
    [HttpPut]
    public async Task<IActionResult> UpdateCTSanPham(CTSanPham ctSanPham)
    {
        await this.ctSanPhamService.Update(ctSanPham);
        return Ok(ctSanPham);
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteCTSanPham(Guid id)
    {
        await this.ctSanPhamService.Delete(id);
        return Ok();
    }
}