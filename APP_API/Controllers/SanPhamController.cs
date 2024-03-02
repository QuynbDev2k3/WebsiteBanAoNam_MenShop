using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers;

[Route("api/sanpham")]
[ApiController]
public class SanPhamController : ControllerBase
{
    private readonly ISanPhamService sanPhamService;

    public SanPhamController(ISanPhamService sanPhamService)
    {
        this.sanPhamService = sanPhamService;
    }

    [Route("getall")]
    [HttpGet]
    public async Task<IActionResult> GetAllSanPham()
    {
        var result = await this.sanPhamService.GetAll();
        return Ok(result);
    }

    [Route("getbyid/{id}")]
    [HttpGet]
    public async Task<IActionResult> GetSanPhamById(Guid id)
    {
        var result = await this.sanPhamService.GetById(id);
        return Ok(result);
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> AddSanPham(SanPham sanPham)
    {
        await this.sanPhamService.Create(sanPham);
        return Created("", sanPham);
    }

    [Route("update")]
    [HttpPut]
    public async Task<IActionResult> UpdateSanPham(SanPham sanPham)
    {
        await this.sanPhamService.Update(sanPham);
        return Ok(sanPham);
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteSanPham(Guid id)
    {
        await this.sanPhamService.Delete(id);
        return Ok();
    }
}