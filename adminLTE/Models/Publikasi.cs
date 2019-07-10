using System;

namespace adminLTE.Models
{
    public class editPublikasi   
    {
        public int Id { get; set; }
        public string Title{ get; set; } = "";
        public string Body{ get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;
    }
} 