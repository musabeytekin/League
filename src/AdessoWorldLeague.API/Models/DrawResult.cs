namespace AdessoWorldLeague.API.Models;

public class DrawResult
{
    public int Id { get; set; }
    public string DrawnBy { get; set; }
    public List<TeamResult> Groups { get; set; } = new List<TeamResult>();
    
    
}