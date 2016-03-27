using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPatienPortal.Models
{
    public class IntakeModel
    {
        public IntakeModel()
        {
            //this.op_NIHStrokeScale = new HashSet<op_NIHStrokeScale>();
            //this.op_PatientRefund = new HashSet<op_PatientRefund>();
            //this.op_PatientSatisfactionSurvey = new HashSet<op_PatientSatisfactionSurvey>();
            //this.op_PhysicianAddendum = new HashSet<op_PhysicianAddendum>();
            //this.op_PhysicianConsult = new HashSet<op_PhysicianConsult>();
            //this.PhysicianConsults = new HashSet<PhysicianConsult>();
        }

        public int IntakeID { get; set; }
        public System.Guid UniqueValue { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ResponseID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
       
        //public virtual rz_User rz_User { get; set; }
        //public virtual rz_Response rz_Response { get; set; }
        //public virtual rz_User rz_User1 { get; set; }
        //public virtual ICollection<op_NIHStrokeScale> op_NIHStrokeScale { get; set; }
        //public virtual ICollection<op_PatientRefund> op_PatientRefund { get; set; }
        //public virtual ICollection<op_PatientSatisfactionSurvey> op_PatientSatisfactionSurvey { get; set; }
        //public virtual ICollection<op_PhysicianAddendum> op_PhysicianAddendum { get; set; }
        //public virtual ICollection<op_PhysicianConsult> op_PhysicianConsult { get; set; }
        //public virtual ICollection<PhysicianConsult> PhysicianConsults { get; set; }
    }
}