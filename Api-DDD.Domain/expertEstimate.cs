﻿using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class expertEstimate:MasterEntity
    {
        public  int projectId { get; set; }
        public virtual Screen1 Screen1 { get; set; }
    }
}