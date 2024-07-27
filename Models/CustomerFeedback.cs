using System.ComponentModel.DataAnnotations;

public class CustomerFeedback
{
    public long CustomerFeedbackId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? ImageUrl { get; set;}
    public string Comments { get; set; } = string.Empty;
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set; }

}