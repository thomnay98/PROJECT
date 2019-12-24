using Newtonsoft.Json;
using QLCT.Models;
using System;

namespace QLCT
{
	public class Wallet
	{
        public string _id { get; set; }

        public string tenVi { get; set; }

        public int currentMoney { get; set; }

        public int thuNhap { get; set; }

        public int duDinhDung { get; set; }

        public int duDinhTichLuy { get; set; }
        public GiaoDich giaoDich { get; set; }

        public long createdAt { get; set; }
    }
}
