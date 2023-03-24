using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TraCuuDieuLuat.Models
{
    public class dieuluat
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Chuong { get; set; }
        public string NDChuong { get; set; }
        public string Dieu { get; set; }
        public string NDDieu { get; set; }
        public string Khoan { get; set; }
        public string NDKhoan { get; set; }
        public string Phatduoi { get; set; }
        public string Phattren { get; set; }
    }
}
