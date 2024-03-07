using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Answer")]
public class Answer
{
    [Key]
    public int Id { get; set; }
    [StringLength(2000)]
    public string Content { get; set; }
    public bool IsKeyAnswer { get; set; } = false;
    public Answer(string content = "", bool isKeyAnswer = false)
    {
        Content = content;
        IsKeyAnswer = isKeyAnswer;
    }
}