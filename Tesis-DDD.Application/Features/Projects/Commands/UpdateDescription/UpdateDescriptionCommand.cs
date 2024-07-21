using MediatR;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Tesis_DDD.Application.Features.Projects.Commands.UpdateDescription
{
    public class UpdateDescriptionCommand:IRequest<int>
    {
        [IgnoreDataMember]
        public int Id { get; set; }
        public string Description{ get; set; }
    }
}
