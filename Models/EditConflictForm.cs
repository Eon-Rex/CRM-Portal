namespace SAMCOCRMRELATION.Models
{
    public class EditConflictForm
    {
        public string? ClientName { get; set; }

        public string? IsListedCompany { get; set; } 

        public string? MatterDescription { get; set; }

        public string? OtherParties { get; set; }

        public string? Status { get; set; }

        public string? NationalPracticeGroup { get; set; }

        public string? SourcedBy { get; set; }

        public string? ReferringFirm { get; set; }

        public string? RevertRequiredBy { get; set; }

        public string? IsFirmPartOfNetwork { get; set; } // Assuming it's a string

        public string? FirmDropdownvalue { get; set; }

        public string? PriceSensitive { get; set; } // Assuming it's a string

        public string? PreviousConflictCirculated { get; set; } // Assuming it's a string

        public string? Comments { get; set; }
    }
}
