using System;

namespace API.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public BaseModel() => CriadoEm = DateTime.Now;
    }
}