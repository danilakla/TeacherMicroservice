using System.ComponentModel.DataAnnotations;

namespace TeacherMicroservice.Models;

public class Subject
{
    [Key]
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }


    public int TeachersId { get; set; }
    public Teachers Teachers{ get; set; }


    public List<SubjectDetail> SubjectDetails { get; set; }
}
