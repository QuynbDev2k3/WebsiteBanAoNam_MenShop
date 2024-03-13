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
    public async Task<IActionResult> AddCTSanPham(Guid idsanpham, Guid idvoucher, Guid idmausac, Guid idkichco, Guid idchatlieu, Guid idanh, Guid idgiamgia, Guid idhang, Guid iddanhgia, string ma, float giaban, int soluong, int age, DateTime ngaytao, string mota, bool trangthai)
    {
        await this.ctSanPhamService.Create(idsanpham, idvoucher, idmausac, idkichco, idchatlieu, idanh, idgiamgia, idhang, iddanhgia, ma, giaban, soluong, age, ngaytao, mota, trangthai);
        return Created("", new {IDSanPham = idsanpham, IdVouCher = idvoucher, IDMauSac = idmausac, IDKichCo = idkichco, IDChatLieu = idchatlieu, IDAnh = idanh, IDGiamGia = idgiamgia, IDHang = idhang, IDDanhGia = iddanhgia, Ma = ma, GiaBan = giaban, SoLuong = soluong, Age = age, NgayTao = ngaytao, MoTa = mota, TrangThai = trangthai });
    }

    [Route("update/{id}")]
    [HttpPut]
    public async Task<IActionResult> UpdateCTSanPham(Guid id, Guid idsanpham, Guid idvoucher, Guid idmausac, Guid idkichco, Guid idchatlieu, Guid idanh, Guid idgiamgia, Guid idhang, Guid iddanhgia, string ma, float giaban, int soluong, int age, DateTime ngaytao, string mota, bool trangthai)
    {
        await this.ctSanPhamService.Update(id, idsanpham, idvoucher, idmausac, idkichco, idchatlieu, idanh, idgiamgia, idhang, iddanhgia, ma, giaban, soluong, age, ngaytao, mota, trangthai);
        return Created("", new {IDSanPham = idsanpham, IdVouCher = idvoucher, IDMauSac = idmausac, IDKichCo = idkichco, IDChatLieu = idchatlieu, IDAnh = idanh, IDGiamGia = idgiamgia, IDHang = idhang, IDDanhGia = iddanhgia, Ma = ma, GiaBan = giaban, SoLuong = soluong, Age = age, NgayTao = ngaytao, MoTa = mota, TrangThai = trangthai });
    }

    [Route("delete/{id}")]
    [HttpDelete]
    public async Task<IActionResult> DeleteCTSanPham(Guid id)
    {
        await this.ctSanPhamService.Delete(id);
        return Ok();
    }
}