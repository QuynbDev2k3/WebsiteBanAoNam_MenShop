namespace APP_DATA.Models;

public class SanPham
{
    public Guid ID { get; set; }
    public Guid IDDanhMucSanPham { get; set; }
    public string Ma { get; set; }
    public string Ten { get; set; }
    public float Gia { get; set; }
    public bool TrangThai { get; set; }
    public virtual CTSanPham? ctsanpham { get; set; }
    public virtual DanhMucSanPham? DanhMucSanPham { get; set; }
    public virtual ICollection<DoiTra>? DoiTras { get; set; }
}