using Api_DDD.Domain.Common;

namespace Api_DDD.Domain
{
    public class Screen1 : Entity
    {
        public string NameProject { get; set; }
        public string FinalUser { get; set; }
        public string DevelopmentMethodology { get; set; }
        public string ResponsiblePosition { get; set; }
        public string DevelopmentType { get; set; }
        public string DevelopmentArea { get; set; }

        public Screen1(string nameProject, string finalUser, string developmentMethodology, string responsiblePosition, string developmentType, string developmentArea)
        {
            NameProject = nameProject;
            FinalUser = finalUser;
            DevelopmentMethodology = developmentMethodology;
            ResponsiblePosition = responsiblePosition;
            DevelopmentType = developmentType;
            DevelopmentArea = developmentArea;
        }

        public Screen1(){ }
    }
}
