using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Question")]
public class Question
{
    [Key]
    public int Id { get; set; }
    [StringLength(2000)]
    public string Content { get; set; }
    public List<Answer> Answers { get; set; }
    [Required]
    public Sight Sight { get; set; }
    public Question() { }
    public Question(string content, List<Answer> answers, Sight sight)
    {
        Content = content;
        Answers = answers;
        Sight = sight;
    }
}