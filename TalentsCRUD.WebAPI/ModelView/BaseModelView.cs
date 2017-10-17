using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TalentsCRUD.WebAPI.ModelView
{
    public class BaseModelView
    {
        public virtual Guid Id { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateAlter { get; set; }
        public int Status { get; set; }
    }
}