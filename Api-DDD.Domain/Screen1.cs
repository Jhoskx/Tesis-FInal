using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class Screen1 : MasterEntity
    {
        public string NameProject { get; set; }
        public string FinalUser { get; set; }
        public string DevelopmentMethodology { get; set; }
        public string ResponsiblePosition { get; set; }
        public string DevelopmentType { get; set; }

    }
}
