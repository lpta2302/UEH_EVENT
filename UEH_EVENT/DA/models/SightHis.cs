using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("SightHis")]
public class SightHis
{
    [Key]
    public int Id { get; set; }
    public int SightId { get; set; }
    public Sight Sight { get; set; }
    public string StudentId { get; set; }
    public Student Student { get; set; }
    [Required]
    public int Point { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }
    public SightHis()
    {
        Sight = new Sight();
        Student = new Student();
    }
    public SightHis(string mssv, int sightId, int point)
    {
        StudentId = mssv;
        SightId = sightId;
        Point = point;
        CreatedAt = DateTime.Now;
    }
}