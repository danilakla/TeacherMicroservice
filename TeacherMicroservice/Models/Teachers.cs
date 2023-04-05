using System.ComponentModel.DataAnnotations;

namespace TeacherMicroservice.Models;

public class Teachers
{
    [Key]
    public int TeacherId { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; } = "********";
    public string LastName { get; set; }
    public int UniversityId { get; set; }

    public List<Subject> Subjects { get; set; }

}
