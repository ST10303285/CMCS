namespace CMCS.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
        public string DocumentPath { get; set; }
        public int ClaimId { get; set; }
        public Claim Claim { get; set; }
    }
}
