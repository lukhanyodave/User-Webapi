using Domain.Common;

namespace Domain.Entities
{
    public class User:BaseEntity
    { 
            public string? Title { get; set; }
            public string Description { get; set; } = string.Empty;
            public DateTimeOffset? CommencementDate { get; set; }
            public DateTimeOffset? TerminationDate { get; set; }
            public string PostId { get; set; } = string.Empty;
    }
}

