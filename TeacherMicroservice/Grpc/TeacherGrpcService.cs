using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using TeacherMicroservice.Data;
using TeacherMicroservice.Models;
using TeacherMicroservice.Protos;

namespace TeacherMicroservice.Grpc;

public class TeacherGrpcService:Teacher.TeacherBase
{
    private readonly ApplicationDbContext _applicationDbContext;

    public TeacherGrpcService(ApplicationDbContext applicationDbContext)
    {
        _applicationDbContext = applicationDbContext;
    }
    public async override Task<TeacherResponse> GetTeacherInfo(EmailTeacher request, ServerCallContext context)
    {
        try
        {
            var teacher = await _applicationDbContext.Teachers.Where(e => e.Email == request.Email).FirstOrDefaultAsync();
            if (teacher is null) throw new Exception("is not founded");
            return new TeacherResponse
            {
                TeacherId = teacher.TeacherId,
                UniversityId = teacher.UniversityId,
            };
        }
        catch (Exception)
        {

            throw;
        }
        
    }

    public override async Task<TeacherResponse> InitTeacher(TeacherRequest request, ServerCallContext context)
    {
        try
        {
            var teacherModel = new Teachers()
            {
                Email = request.Email,
                LastName = request.LastName,
                Name = request.Name,
                UniversityId=request.UniversityId,
            };
             await _applicationDbContext.Teachers.AddAsync(teacherModel);
             await _applicationDbContext.SaveChangesAsync();
        return new TeacherResponse() { TeacherId=teacherModel.TeacherId, UniversityId=teacherModel.UniversityId };
        }
        catch (Exception e)
        {

            throw e;
        }
 
    }
}
