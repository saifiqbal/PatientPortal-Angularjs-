using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository;
using Repository.GenericRepository;
using Repository.UnitOfWork;
using DemoPatienPortal.Models;
using System.Web.Script.Serialization;

namespace DemoPatienPortal.Controllers
{
    public class IntakeController : ApiController
    {
        //private UnitOfWork _UnitOfWork = null; 
        public IntakeController()
        {
            _UnitOfWork = new UnitOfWork();
        }  
        // GET: api/Intake
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Intake/5
        public List<IntakeModel> Get(int id)
        {
            List<IntakeModel> intakes = new List<IntakeModel>();
            //var data= _UnitOfWork.Repository<op_Intake>().GetAll().ToList();
            //foreach (var intakedata in data)
            //{
            //    IntakeModel intakemodel = new IntakeModel();
            //    intakemodel.IntakeID = intakedata.IntakeID;
            //    intakemodel.CreatedBy = intakedata.CreatedBy;
            //    intakemodel.IsDeleted = intakedata.IsDeleted;
            //    intakemodel.ResponseID = intakedata.ResponseID;
            //    intakemodel.UniqueValue = intakedata.UniqueValue;
            //    intakemodel.UserID = intakedata.UserID;
            //    intakes.Add(intakemodel);
            //}



            //var jsonSerialiser = new JavaScriptSerializer();
            //var json = jsonSerialiser.Serialize(intakes);

            return intakes;
        }

        // POST: api/Intake
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Intake/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Intake/5
        public void Delete(int id)
        {
        }
    }
}
