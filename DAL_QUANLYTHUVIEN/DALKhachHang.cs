using System;
using System.Collections.Generic;
using System.Data;
using DTO_QUANLYTHUVIEN;
using Microsoft.Data.SqlClient;

namespace DAL_QUANLYTHUVIEN
{
    public class DALKhachHang
    {
        public List<KhachHang> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<KhachHang> list = new List<KhachHang>();
            using (SqlDataReader reader = DBUtil.Query(sql, args))
            {
                while (reader.Read())
                {
                    list.Add(MapReaderToKhachHang(reader));
                }
            }
            return list;
        }

        public List<KhachHang> SelectAll()
        {
            string sql = "SELECT * FROM KhachHang";
            return SelectBySql(sql, new List<object>());
        }

        public KhachHang? GetKhachHangByEmail(string email)
        {
            string sql = "SELECT * FROM KhachHang WHERE Email = @0";
            var args = new List<object> { email };

            using (SqlDataReader reader = DBUtil.Query(sql, args))
            {
                if (reader.HasRows && reader.Read())
                {
                    return MapReaderToKhachHang(reader);
                }
            }
            return null;
        }

        public void InsertKhachHang(KhachHang kh)
        {
            string sql = @"INSERT INTO KhachHang (MaKhachHang, TenKhachHang, Email, SoDienThoai, CCCD, TrangThai, NgayTao)
                           VALUES (@0, @1, @2, @3, @4, @5, @6)";

            List<object> parameters = new List<object>
            {
                kh.MaKhachHang,
                kh.TenKhachHang,
                kh.Email,
                kh.SoDienThoai,
                kh.CCCD,
                kh.TrangThai,
                kh.NgayTao
            };

            DBUtil.Update(sql, parameters);
        }

        public string UpdateKhachHang(KhachHang kh)
        {
            string sql = @"UPDATE KhachHang 
                           SET TenKhachHang = @0,
                               Email = @1,
                               SoDienThoai = @2,
                               CCCD = @3,
                               TrangThai = @4,
                               NgayTao = @5
                           WHERE MaKhachHang = @6";

            List<object> parameters = new List<object>
            {
                kh.TenKhachHang,
                kh.Email,
                kh.SoDienThoai,
                kh.CCCD,
                kh.TrangThai,
                kh.NgayTao,
                kh.MaKhachHang
            };

            try
            {
                DBUtil.Update(sql, parameters);
                return "";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteKhachHang(string maKH)
        {
            try
            {
                string sql = "DELETE FROM KhachHang WHERE MaKhachHang = @0";
                List<object> args = new List<object> { maKH };
                DBUtil.Update(sql, args);
                return "";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public List<KhachHang> SearchKhachHang(string keyword)
        {
            string sql = @"SELECT * FROM KhachHang 
                           WHERE MaKhachHang LIKE @0 
                              OR TenKhachHang LIKE @0 
                              OR Email LIKE @0 
                              OR CCCD LIKE @0";

            List<object> args = new List<object> { "%" + keyword + "%" };
            return SelectBySql(sql, args);
        }

        private KhachHang MapReaderToKhachHang(SqlDataReader reader)
        {
            return new KhachHang
            {
                MaKhachHang = reader["MaKhachHang"].ToString(),
                TenKhachHang = reader["TenKhachHang"].ToString(),
                Email = reader["Email"].ToString(),
                SoDienThoai = reader["SoDienThoai"].ToString(),
                CCCD = reader["CCCD"].ToString(),
                TrangThai = Convert.ToBoolean(reader["TrangThai"]),
                NgayTao = reader["NgayTao"] != DBNull.Value ? Convert.ToDateTime(reader["NgayTao"]) : DateTime.MinValue
            };
        }
    }
}
