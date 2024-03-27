using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TPointHis")]
public class TPointHis
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string StudentId { get; set; }
    public Student Student { get; set; }
    [Required]
    public int Point { get; set; }
    [StringLength(2000)]
    public string? Content { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }

    public TPointHis(string studentId, int point, string? content)
    {
        StudentId = studentId;
        Point = point;
        Content = content;
        CreatedAt = DateTime.Now;
    }
    public TPointHis()
    {
        CreatedAt = DateTime.Now;
    }
}