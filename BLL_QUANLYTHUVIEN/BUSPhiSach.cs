using System;
using System.Collections.Generic;
using System.Linq;
using DAL_QUANLYTHUVIEN;
using DTO_QUANLYTHUVIEN;

namespace BLL_QUANLYTHUVIEN
{
    public class BusPhiSach
    {
        private DALPhiSach dalPhiSach = new DALPhiSach();

        public List<PhiSach> GetAll()
        {
            return dalPhiSach.SelectAll();
        }

        public PhiSach? GetById(string maPhiSach)
        {
            return dalPhiSach.GetByMaPhiSach(maPhiSach);
        }

        public string Add(PhiSach phiSach)
        {
            if (string.IsNullOrWhiteSpace(phiSach.MaPhiSach))
                return "Mã phiếu sách không được để trống.";

            if (GetById(phiSach.MaPhiSach) != null)
                return "Mã phiếu sách đã tồn tại.";

            try
            {
                dalPhiSach.Insert(phiSach);
                return "";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string Update(PhiSach phiSach)
        {
            if (string.IsNullOrWhiteSpace(phiSach.MaPhiSach))
                return "Mã phiếu sách không được để trống.";

            var existing = GetById(phiSach.MaPhiSach);
            if (existing == null)
                return "Phiếu sách không tồn tại.";

            return dalPhiSach.Update(phiSach);
        }

        public string Delete(string maPhiSach)
        {
            if (string.IsNullOrWhiteSpace(maPhiSach))
                return "Mã phiếu sách không được để trống.";

            try
            {
                return dalPhiSach.Delete(maPhiSach);
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public List<PhiSach> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();

            var list = GetAll();

            return list.Where(p =>
                (p.MaPhiSach ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (p.MaSach ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                p.PhiMuon.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (p.PhiPhat?.ToString() ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (p.TrangThai?.ToString() ?? "").Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                (p.NgayTao?.ToString("dd/MM/yyyy") ?? "").Contains(keyword)
            ).ToList();
        }
    }
}
