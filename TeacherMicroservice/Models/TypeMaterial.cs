using System.ComponentModel.DataAnnotations;

namespace TeacherMicroservice.Models;

public class TypeMaterial
{
    [Key]
    public int TypeMaterialId{ get; set; }
    public string   TypeName     { get; set; }

    public List<SubjectDetail> SubjectDetails { get; set; }
}
