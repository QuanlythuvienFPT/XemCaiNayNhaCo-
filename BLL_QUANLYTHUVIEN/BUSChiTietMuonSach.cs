using System.Collections.Generic;
using DAL_QuanLyThuVien;
using DTO_QUANLYTHUVIEN;

namespace BLL_QuanLyThuVien
{
    public class BUSChiTietMuonSach
    {
        private DALChiTietMuonSach dal = new DALChiTietMuonSach();

        public List<ChiTietMuonSach> GetChiTietByMaMuonTra(string maMuonTra) => dal.GetChiTietByMaMuonTra(maMuonTra);

        public bool Add(ChiTietMuonSach ct) => dal.Insert(ct);

        public bool Update(ChiTietMuonSach ct) => dal.Update(ct);

        public bool Delete(string maChiTiet) => dal.Delete(maChiTiet);
    }
}
