﻿using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class Resource:MasterEntity
    {
        public string Name {get; set;}
        public int ProjectId { get; set; }
        public int ExperienceId { get; set; }
    }
}
