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
    public async Task<IActionResult> GetNhanVienById( Guid id)
    {
        var result = await this.nhanVienService.GetById(id);
        return Ok(result);
    }
    
    [Route("add")]
    [HttpPost]
    public async Task<IActionResult> AddNhanVien([FromQuery] Guid idrole, string ma, string ten, string sdt, string email, string diachi, string matkhau, bool trangthai)
    {
        await this.nhanVienService.Create(idrole, ma, ten, sdt, email, diachi, matkhau, trangthai);
        return Created("", new { IDRole = idrole, Ma = ma, Ten = ten, SDT = sdt, Email = email, DiaChi = diachi, MatKhau = matkhau, TrangThai = trangthai });
    }
    
    [Route("update/{id}")]
    [HttpPut]
    public async Task<IActionResult> UpdateNhanVien( Guid id, Guid idrole, string ma, string ten, string sdt, string email, string diachi, string matkhau, bool trangthai)
    {
        await this.nhanVienService.Update(id, idrole, ma, ten, sdt, email, diachi, matkhau, trangthai);
        return Created("", new {Id = id, IDRole = idrole, Ma = ma, Ten = ten, SDT = sdt, Email = email, DiaChi = diachi, MatKhau = matkhau, TrangThai = trangthai });
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteNhanVien(Guid id)
    {
        await this.nhanVienService.Delete(id);
        return Ok();
    }
}