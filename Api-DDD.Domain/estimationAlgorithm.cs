﻿using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class estimationAlgorithm:MasterEntity
    {
        public int idproject { get; set; }
        public virtual Screen1 Screen1 { get; set; }
    }
}