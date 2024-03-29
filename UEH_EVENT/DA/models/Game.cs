using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Game")]
public class Game
{
    [Key]
    public int Id { get; set; }
    [StringLength(20)]
    public string Name { get; set; }
    public string? Data { get; set; }
    public Game(string name = "")
    {
        Name = name;
    }
}