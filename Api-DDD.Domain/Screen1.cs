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


        public Screen1 (string nameProject, string finalUser, string developmentMethodology, string responsiblePosition, string developmentType)  
        {
        NameProject = nameProject;
            FinalUser = finalUser;
            DevelopmentMethodology = developmentMethodology;
            ResponsiblePosition = responsiblePosition;
            DevelopmentType = developmentType;
        }
        public Screen1(){ }
    }
}
