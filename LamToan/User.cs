using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamToan
{
    // them public cho may cai class hay form o ngoai no nhin thay thang nay
    // doi tuong user để luu user, password va diem, vv
    public class User
    {
        // format la modifier - type - ten cua thuoc tinh {get;set;}
        //dau tien la id, thang nao cung can id
        public int Id { get; set; }
        //thuoc tinh name - ten cua user
        public string Name { get; set; }
        //dung de dang nhap
        public string UserName { get; set; }
        public string Password { get; set; }
        //diem so
        public double? Point { get; set; }
    }
}
