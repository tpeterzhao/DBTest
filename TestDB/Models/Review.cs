using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDB.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int PaperID { get; set; }
        public int ReviewerID { get; set; }
        [Display(Name = "Appropriateness of Topic")]
        [Column(TypeName = "decimal(3,2)")]
        public float AppropriatenessOfTopic { get; set; }
        [Display(Name = "Timeliness of Topic")]
        [Column(TypeName = "decimal(3,2)")]
        public float TimelinessOfTopic { get; set; }
        [Display(Name = "Supportive Evidence")]
        [Column(TypeName = "decimal(3,2)")]
        public float SupportiveEvidence { get; set; }
        [Display(Name = "Technical Quality")]
        [Column(TypeName = "decimal(3,2)")]
        public float TechnicalQuality { get; set; }
        [Display(Name = "Scope of Coverage")]
        [Column(TypeName = "decimal(3,2)")]
        public float ScopeOfCoverage { get; set; }
        [Display(Name = "Citation of Previous Work")]
        [Column(TypeName = "decimal(3,2)")]
        public float CitationOfPreviousWork { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        public float Originality { get; set; }
        [Display(Name = "Content Comments")]
        [StringLength(int.MaxValue)]
        public string ContentComments { get; set; }
        [Display(Name = "Organization of Paper")]
        [Column(TypeName = "decimal(3,2)")]
        public float OrganizationOfPaper { get; set; }
        [Display(Name = "Clarity of Main Message")]
        [Column(TypeName = "decimal(3,2)")]
        public float ClarityOfMainMessage { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public float Mechanics { get; set; }
        [Display(Name = "Written Document Comments")]
        [StringLength(int.MaxValue)]
        public string WrittenDocumentComments { get; set; }
        [Display(Name = "Suitability for Presentation")]
        [Column(TypeName = "decimal(3,2)")]
        public float SuitabilityForPresentation { get; set; }
        [Display(Name = "Potential Interest in Topic")]
        [Column(TypeName = "decimal(3,2)")]
        public float PotentialInterestInTopic { get; set; }
        [Display(Name = "Potential for Oral Presentation Comments")]
        [StringLength(int.MaxValue)]
        public string PotentialForOralPresentationComments { get; set; }
        [Display(Name = "Overall Rating")]
        [Column(TypeName = "decimal(3,2)")]
        public float OverallRating { get; set; }
        [Display(Name = "Overall Rating Comments")]
        [StringLength(int.MaxValue)]
        public string OverallRatingComments { get; set; }
        [Display(Name = "Comfort Level Topic")]
        [Column(TypeName = "decimal(3,2)")]
        public float ComfortLevelTopic { get; set; }
        [Display(Name = "Comfort Level Acceptability")]
        [Column(TypeName = "decimal(3,2)")]
        public float ComfortLevelAcceptability { get; set; }
        public bool Complete { get; set; }

    }
}
