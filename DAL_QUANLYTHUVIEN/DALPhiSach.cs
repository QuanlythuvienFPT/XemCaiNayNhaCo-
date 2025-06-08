using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QUANLYTHUVIEN;

namespace DAL_QUANLYTHUVIEN
{
    public class DALPhiSach
    {
        // Lấy danh sách phiếu sách theo câu truy vấn SQL
        public List<PhiSach> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhiSach> list = new List<PhiSach>();
            using (SqlDataReader reader = DBUtil.Query(sql, args))
            {
                while (reader.Read())
                {
                    list.Add(MapReaderToPhiSach(reader));
                }
            }
            return list;
        }

        // Lấy tất cả phiếu sách
        public List<PhiSach> SelectAll()
        {
            string sql = "SELECT * FROM PhiSach";
            return SelectBySql(sql, new List<object>());
        }

        // Lấy phiếu sách theo mã
        public PhiSach? GetByMaPhiSach(string maPhiSach)
        {
            string sql = "SELECT * FROM PhiSach WHERE MaPhiSach = @0";
            var parameters = new List<object> { maPhiSach };
            using (SqlDataReader reader = DBUtil.Query(sql, parameters))
            {
                if (reader.HasRows && reader.Read())
                {
                    return MapReaderToPhiSach(reader);
                }
            }
            return null;
        }

        // Thêm phiếu sách mới
        public void Insert(PhiSach phiSach)
        {
            string sql = @"INSERT INTO PhiSach (MaPhiSach, MaSach, PhiMuon, PhiPhat, TrangThai, NgayTao)
                           VALUES (@0, @1, @2, @3, @4, @5)";
            var parameters = new List<object>
            {
                phiSach.MaPhiSach,
                phiSach.MaSach,
                phiSach.PhiMuon,
                phiSach.PhiPhat ?? 0,
                phiSach.TrangThai ?? true,
                phiSach.NgayTao ?? DateTime.Now
            };
            DBUtil.Update(sql, parameters);
        }

        // Cập nhật phiếu sách
        public string Update(PhiSach phiSach)
        {
            string sql = @"UPDATE PhiSach SET 
                            MaSach = @0,
                            PhiMuon = @1,
                            PhiPhat = @2,
                            TrangThai = @3,
                            NgayTao = @4
                           WHERE MaPhiSach = @5";

            var parameters = new List<object>
            {
                phiSach.MaSach,
                phiSach.PhiMuon,
                phiSach.PhiPhat ?? 0,
                phiSach.TrangThai ?? true,
                phiSach.NgayTao ?? DateTime.Now,
                phiSach.MaPhiSach
            };

            try
            {
                DBUtil.Update(sql, parameters);
                return ""; // Không lỗi
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        // Xóa phiếu sách theo mã
        public string Delete(string maPhiSach)
        {
            try
            {
                string sql = "DELETE FROM PhiSach WHERE MaPhiSach = @0";
                var parameters = new List<object> { maPhiSach };
                DBUtil.Update(sql, parameters);
                return "";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        // Tìm kiếm phiếu sách theo từ khóa
        public List<PhiSach> Search(string keyword)
        {
            string sql = @"SELECT * FROM PhiSach 
                           WHERE MaPhiSach LIKE @0 OR MaSach LIKE @0";

            var parameters = new List<object> { "%" + keyword + "%" };
            return SelectBySql(sql, parameters);
        }

        // Chuyển đổi SqlDataReader thành đối tượng PhiSach
        private PhiSach MapReaderToPhiSach(SqlDataReader reader)
        {
            return new PhiSach
            {
                MaPhiSach = reader["MaPhiSach"].ToString(),
                MaSach = reader["MaSach"].ToString(),
                PhiMuon = Convert.ToDecimal(reader["PhiMuon"]),
                PhiPhat = reader["PhiPhat"] != DBNull.Value ? Convert.ToDecimal(reader["PhiPhat"]) : (decimal?)null,
                TrangThai = reader["TrangThai"] != DBNull.Value ? Convert.ToBoolean(reader["TrangThai"]) : (bool?)null,
                NgayTao = reader["NgayTao"] != DBNull.Value ? Convert.ToDateTime(reader["NgayTao"]) : (DateTime?)null
            };
        }
    }
}
