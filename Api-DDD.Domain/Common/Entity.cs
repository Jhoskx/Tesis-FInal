namespace Api_DDD.Domain.Common
{
    public class Entity
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public bool Status { get; set; } // Por revisar
    }
}
