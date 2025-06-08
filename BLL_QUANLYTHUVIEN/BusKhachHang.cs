using System;
using System.Collections.Generic;
using System.Linq;
using DAL_QUANLYTHUVIEN;
using DTO_QUANLYTHUVIEN;

namespace BLL_QUANLYTHUVIEN
{
    public class BusKhachHang
    {
        DALKhachHang dal = new DALKhachHang();

        public List<KhachHang> GetAll()
        {
            return dal.SelectAll();
        }

        public string AddKhachHang(KhachHang kh)
        {
            if (string.IsNullOrWhiteSpace(kh.MaKhachHang))
                return "Mã khách hàng không được để trống.";

            if (dal.GetKhachHangByEmail(kh.Email) != null)
                return "Email đã tồn tại.";

            try
            {
                dal.InsertKhachHang(kh);
                return "";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateKhachHang(KhachHang kh)
        {
            var existing = dal.GetKhachHangByEmail(kh.Email);

            if (existing != null && existing.MaKhachHang != kh.MaKhachHang)
                return "Email đã tồn tại.";

            return dal.UpdateKhachHang(kh);
        }

        public string DeleteKhachHang(string maKH)
        {
            return dal.DeleteKhachHang(maKH);
        }

        public List<KhachHang> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();

            var list = GetAll();
            return list.Where(kh =>
                (kh.MaKhachHang ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (kh.TenKhachHang ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (kh.Email ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (kh.CCCD ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (kh.SoDienThoai ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                kh.TrangThai.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (kh.NgayTao.ToString("dd/MM/yyyy")).Contains(keyword)
            ).ToList();
        }
    }
}
