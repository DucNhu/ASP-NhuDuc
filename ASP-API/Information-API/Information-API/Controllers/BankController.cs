using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Information_API.Models;

namespace Information_API.Controllers
{
    public class BankController : ApiController
    {
        private readonly DB_BankEntities _context = new DB_BankEntities();
        
        //create
        [HttpPost]
        [Authorize]
        [Route("api/Bank/Create")]
        public IHttpActionResult Create(BankModel bankModel)
        {
            var bank = new Table_DB_Bank()
            {
                BankName = bankModel.BankName,
                IFSC = bankModel.IFSC
            };
            _context.Table_DB_Bank.Add(bank);
            _context.SaveChanges();
            return Ok("Success");
        }

        //Get
        //[HttpGet]
        //[Authorize]
        [Route("api/Bank/GetAll")]
        public IHttpActionResult GetAll()
        {
            var banks = _context.Table_DB_Bank.ToList();
            return Ok(banks);
        }
    }
}
