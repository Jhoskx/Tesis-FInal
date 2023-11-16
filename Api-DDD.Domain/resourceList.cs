using Api_DDD.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_DDD.Domain
{
    public class resourceList:MasterEntity
    {
        public int idEstimate { get; set; }
        public virtual expertEstimate ExpertEstimate { get; set; }
    }
}
