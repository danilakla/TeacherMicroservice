using Microsoft.EntityFrameworkCore;
using TeacherMicroservice.Models;

namespace TeacherMicroservice.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
    {

    }
    

    public DbSet<Teachers>  Teachers{ get; set; }
    public DbSet<EducationMaterial>   EducationMaterials{ get; set; }
    public DbSet<SubjectDetail>    SubjectDetails{ get; set; }
    public DbSet<Subject>     Subjects { get; set; }
    public DbSet<TypeMaterial>  TypeMaterials{ get; set; }
}
