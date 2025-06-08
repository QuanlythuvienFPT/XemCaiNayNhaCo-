using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QUANLYTHUVIEN;
using DTO_QUANLYTHUVIEN;

namespace BLL_QuanLyThuVien
{
    public class BUSSach
    {
        private readonly DALSach dalsach = new DALSach();


        public List<Sach> LayTatCaSach()
        {
            return dalsach.GetAllSach();
        }



        public Sach LaySachTheoMa(string maSach)
        {
            return dalsach.GetSachByMa(maSach);
        }

        public void ThemSach(Sach sach)
        {
            var existing = LaySachTheoMa(sach.MaSach);
            if (existing != null)
            {
                throw new Exception($"Mã sách '{sach.MaSach}' đã tồn tại, vui lòng nhập mã khác.");
            }
            dalsach.InsertSach(sach);
        }



        public void CapNhatSach(Sach sach)
        {
            dalsach.UpdateSach(sach);
        }




        public void XoaSach(string maSach)
        {
            dalsach.DeleteSach(maSach);
        }



        public List<Sach> TimKiemSach(string tuKhoa)
        {
            return dalsach.TimKiemSach(tuKhoa);
        }




        public bool KiemTraTheLoaiTonTai(string maTheLoai)
        {
            string sql = "SELECT COUNT(*) FROM TheLoaiSach WHERE MaTheLoai = @0";
            object result = DBUtil.ExecuteScalar(sql, new List<object> { maTheLoai });
            if (result != null && int.TryParse(result.ToString(), out int count))
            {
                return count > 0;
            }
            return false;
        }

    }
}
