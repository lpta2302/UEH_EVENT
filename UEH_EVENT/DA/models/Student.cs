using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
[Table("Student")]
public class Student
{
    [Key]
    [StringLength(20)]
    public string Mssv { get; set; }
    public int TPoint { get; set; }
    [StringLength(100)]
    public string Name { get; set; }
    [StringLength(4)]
    public string Batch { get; set; }
    [StringLength(20)]
    public string ClassId { get; set; }
    [StringLength(100)]
    public string Major { get; set; }
    public Student(string mssv = "", string name = "", string batch = "", string classId = "", string major = "", int tPoint = 0)
    {
        Mssv = mssv;
        TPoint = tPoint;
        Name = name;
        Batch = batch;
        ClassId = classId;
        Major = major;
    }
}
