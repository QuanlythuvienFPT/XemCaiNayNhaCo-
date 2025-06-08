using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QUANLYTHUVIEN
{
    public class MuonTraSach
    {
        public string MaMuonTra { get; set; }
        public string MaKhachHang { get; set; }
        public string MaNhanVien { get; set; }
        public DateOnly NgayMuon { get; set; }
        public DateOnly NgayTra { get; set; }
        public string MaTrangThai { get; set; }  // Thay bool TrangThai thành string MaTrangThai
        public DateTime NgayTao { get; set; }
    }

}
