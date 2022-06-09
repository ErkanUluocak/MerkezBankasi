using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerkezBankasi
{
    public class RequestData
    {
        public int Gun { get; set; }
        public int Ay  { get; set; }
        public int Yil  { get; set; }
        public bool IsBugun  { get; set; }
    }


    public class ResponseDataKur
    {
        public string Kodu { get; set; }
        public string Adi { get; set; }
        public int  Birimi { get; set; }
        public decimal AlisKuru { get; set; }
        public decimal SatisKuru { get; set; }
        public decimal EfektifAlisKuru { get; set; }
        public decimal EfektifSatisKuru { get; set; }
    }

    public class ResponseData
    {
        public List<ResponseDataKur> Data { get; set; }
        public string Hata { get; set; }
    }



}
