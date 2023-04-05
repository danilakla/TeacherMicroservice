using System.ComponentModel.DataAnnotations;

namespace TeacherMicroservice.Models;

public class EducationMaterial
{
    [Key]
    public int EducationMaterialId { get; set; }

    public int Course { get; set; }
    public string FacultieName { get; set; }
}
