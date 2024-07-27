namespace CarServiceProject.Models;

public class SearchParameters
{
    public string? SearchText { get; set; }
    public int? CategoryId { get; set; }
    public int? MinPrice { get; set; }
    public int? MaxPrice { get; set; }
}