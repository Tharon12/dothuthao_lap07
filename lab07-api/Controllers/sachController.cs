using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using lab07_api.Models;
namespace lab07_api.Controllers
{
    public class sachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach{Id = 1, Title = "Tôi thấy hoa vàng trên cỏ xanh", AuthorName="Nguyễn Nhật Ánh", Price=1, Content = "Truyện kể về tuổi thơ,..."},
            new Sach{Id = 2, Title = "Chùa đàn", AuthorName="Nguyễn Tuân", Price=1, Content = "Truyện kể về,..."},
        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p) => p.Id == id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
