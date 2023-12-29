﻿using MediatR;
using System.Runtime.Serialization;

namespace Tesis_DDD.Application.Features.Screen1s.Commands.UpdateScreen1
{
    public class UpdateScreen1Command:IRequest<string>
    {
    
        public string NameProject { get; set; }
        public string FinalUser { get; set; }
        public string DevelopmentMethodology { get; set; }
        public string ResponsiblePosition { get; set; }
        public string DevelopmentType { get; set; }
        public string DevelopmentArea { get; set; }
    }
}
