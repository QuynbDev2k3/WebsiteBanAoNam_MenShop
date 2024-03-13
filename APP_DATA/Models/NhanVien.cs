namespace APP_DATA.Models;

public class NhanVien
{
    public Guid ID { get; set; }
    public Guid IDRole { get; set; }
    public string Ma { get; set; }
    public string Ten { get; set; }
    public string SDT { get; set; }
    public string Email { get; set; }
    public string DiaChi { get; set; }
    public string MatKhau { get; set; }
    public bool TrangThai { get; set; }
    public virtual ICollection<HoaDon>? HoaDons { get; set; }
    public virtual Role? Role { get; set; }
}