using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
[Table("Account")]
public class Account
{
    [Key]
    [StringLength(20)]
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public string Username { get; set; }
    [StringLength(20)]
    public string? StudentId { get; set; }
    public Student? Student { get; set; }
    [Required]
    [StringLength(20)]
    public string Password { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    public string AccType { get; set; }
    public string? GameSession { get; set; } = null;
    public string? SightSession { get; set; } = null;
    public Account() { }
    public Account(string username, string password, string name, string accType)
    {
        Username = username;
        Password = password;
        Name = name;
        AccType = accType;
        Student = null;
    }
    public Account(string username, string password, string name, string accType, string? studentId)
    {
        Username = studentId;
        Password = password;
        Name = name;
        AccType = Constants.STUDENT_ACC;
        StudentId = studentId;
    }
}
