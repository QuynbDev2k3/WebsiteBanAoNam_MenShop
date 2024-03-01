using APP_API.IServices;
using APP_DATA.Models;
using Microsoft.AspNetCore.Mvc;

namespace APP_API.Controllers;

[Route("api/nhanvien")]
[ApiController]
public class NhanVienController : ControllerBase
{
    private readonly INhanVienService nhanVienService;

    public NhanVienController(INhanVienService nhanVienService)
    {
        this.nhanVienService = nhanVienService;
    }

    [Route("getall")]
    [HttpGet]
    public async Task<IActionResult> GetAllNhanVien()
    {
        var result = await this.nhanVienService.GetAll();
        return Ok(result);
    }

    [Route("getbyid/{id}")]
    [HttpGet]
    public async Task<IActionResult> GetNhanVienById(Guid id)
    {
        var result = await this.nhanVienService.GetById(id);
        return Ok(result);
    }

    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> AddNhanVien(NhanVien nhanVien)
    {
        await this.nhanVienService.Create(nhanVien);
        return Created("", nhanVien);
    }

    [Route("update")]
    [HttpPut]
    public async Task<IActionResult> UpdateNhanVien(NhanVien nhanVien)
    {
        await this.nhanVienService.Update(nhanVien);
        return Ok(nhanVien);
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteNhanVien(Guid id)
    {
        await this.nhanVienService.Delete(id);
        return Ok();
    }
}