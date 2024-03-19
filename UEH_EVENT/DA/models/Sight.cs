using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Sight")]
public class Sight
{
    [Key]
    public int Id { get; set; }
    public int Time { get; set; }
    [StringLength(20)]
    public string Name { get; set; }
    [StringLength(2000)]
    public string? Preview { get; set; }
    [Column(TypeName = "Date")]
    public DateTime CreatedAt { get; set; }
    public List<Question>? Questions { get; set; }
    public Sight()
    {
        Name = "";
        Preview = "";
    }

    public Sight(string name = "", string? preview = "", int time = 0, List<Question>? questions = null)
    {
        Name = name;
        Preview = preview;
        CreatedAt = DateTime.Now;
        Questions = questions;
        Time = time;
    }
}