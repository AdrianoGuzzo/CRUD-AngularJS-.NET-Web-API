using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentsCRUD.Model;
using TalentsCRUD.Repository;

namespace TalentsCRUD.Service
{
    public abstract class ServiceBase
    {
        public ServiceBase(InjectRepository injectRepository)
        {
            injectRepository = new InjectRepository();      
        }
    }
}
