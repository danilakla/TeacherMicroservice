using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;

namespace TeacherMicroservice.Models;

public class SubjectDetail
{
    [Key]
    public int SubjectDetailId { get; set; }
    public int FileName { get; set; }
    public byte [] Data { get; set; }

    public int SubjectId { get; set; }
    public Subject Subject { get; set; }

    public int TypeMaterialId{ get; set; }
    public TypeMaterial TypeMaterial { get; set; }
}
