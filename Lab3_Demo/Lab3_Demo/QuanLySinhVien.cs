using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Globalization;

namespace Lab3_Demo
{
    public enum TimTheo
    {
        MaSV,
        HoTen,
        NgaySinh
    }
    // Khai báo một delegate SoSanh
    public delegate int SoSanh(object sv1, object sv2);
    internal class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        // Thêm một sinh viên vào danh sách
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        //Xóa các obj trong danh sách nếu thỏa điều kiện so sánh
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }
        //Tìm một sinh viên trong danh sách thỏa điều kiện so sánh
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
        //Tìm một sinh viên trong danh sách thỏa điều kiện so sánh,
        public bool Sua(SinhVien svsua, object obj, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for (i = 0; i < count; i++)
                if (ss(obj, this[i]) == 0)
                {
                    this[i] = svsua;
                    kq = true;
                    break;
                }
            return kq;
        }
        // Hàm đọc danh sách sinh viên từ tập tin txt
        public void DocTuFile()
        {
            string filename = "DanhSachSV.csv", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename,FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.NgaySinh = DateTime.ParseExact(s[2],"dd/MM/yyyy",CultureInfo.InvariantCulture);
                sv.DiaChi = s[3];
                sv.Lop = s[4];
                sv.Hinh = s[7];
                sv.GioiTinh = false;
                if (s[5] == "Nam")
                    sv.GioiTinh = true;
                string[] cn = s[6].Split(',');
                foreach (string c in cn)
                    sv.ChuyenNganh.Add(c);
                this.Them(sv);
            }
        }

        public void SapXep(TimTheo Loai)
        {
            DanhSach.Sort(delegate (SinhVien sv1, SinhVien sv2)
            {
                if (Loai == TimTheo.MaSV)
                    return sv1.MaSo.CompareTo(sv2.MaSo);
                else if (Loai == TimTheo.HoTen)
                    return sv1.HoTen.CompareTo(sv2.HoTen);
                return DateTime.Compare(sv1.NgaySinh, sv2.NgaySinh);
            });
        }
        // tim kiem
        public List<SinhVien> TimKiem(TimTheo Loai, string thuoctinh)
        {
            return DanhSach.FindAll(delegate (SinhVien sv1)
            {
                if (Loai == TimTheo.MaSV)
                    return sv1.MaSo == thuoctinh;
                else if (Loai == TimTheo.HoTen)
                    return sv1.HoTen.Trim().ToLower() == thuoctinh.Trim().ToLower();
                return sv1.NgaySinh == DateTime.ParseExact(thuoctinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            });
        }
    }


}
