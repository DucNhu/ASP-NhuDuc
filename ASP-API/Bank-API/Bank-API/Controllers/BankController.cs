using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bank_API.Models;

namespace Bank_API.Controllers
{
    public class BankController : ApiController
    {
        private readonly DB_BankEntities _Context = new DB_BankEntities();




        //Create
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

            _Context.Table_DB_Bank.Add(bank);
            _Context.SaveChanges();
            return Ok("Success");
        }

        //Get
        [HttpGet]
        [Authorize]
        [Route("api/Bank/GetAll")]
        public IHttpActionResult getAll()
        {
            var banks = _Context.Table_DB_Bank.ToList();
            return Ok(banks);
        }


        //Update
        [HttpPut]
        [Authorize]
        [Route("api/Bank/Modify")]

        public IHttpActionResult Modify(BankModel bankModel)
        {
            var bank = new Table_DB_Bank()
            {
                BankName = bankModel.BankName,
                ID = bankModel.Id,
                IFSC = bankModel.IFSC
            };
            return Ok("Success");
        }



        //Delete
        [HttpPut]
        [Authorize]
        [Route("api/Bank/Delete/{id}")]

        public IHttpActionResult Delete(int id)
        {
            var bank = _Context.Table_DB_Bank.SingleOrDefault(e => e.ID == id);
            _Context.Table_DB_Bank.Remove(bank);
            _Context.SaveChanges();
            return Ok("Success");
        }
    }
}

