using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("PlayHis")]
public class PlayHis
{
    [Key]
    public int Id { get; set; }
    public int GameId { get; set; }
    public Game Game { get; set; }
    public string StudentId { get; set; }
    public Student Student { get; set; }
    [Required]
    public int Point { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    public PlayHis() {
        CreatedAt = DateTime.Now;
    }

    public PlayHis(string studentId, int gameId, int point)
    {
        StudentId = studentId;
        GameId = gameId;
        Point = point;
        CreatedAt = DateTime.Now;
    }
}