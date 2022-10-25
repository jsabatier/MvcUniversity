using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcUniversity.Data;
using MvcUniversity.Models;

namespace MvcUniversity.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UniversityApiController : ControllerBase
{
    private readonly MvcUniversityContext _context;

    public UniversityApiController(MvcUniversityContext context)
    {
        _context = context;
    }

    // GET: api/MovieApi
    public async Task<ActionResult<IEnumerable<Student>>> GetStudent()
    {
        return await _context.Students.ToListAsync();
    }

    //Get Todo by Id
    [HttpGet("{id}")]
    public async Task<ActionResult<Student>> GetStudent(int id)
    {
        var stud = await _context.Students.FindAsync(id);
        if (stud == null)
            return NotFound();
        return stud;
    }

    [HttpPost]
    public async Task<ActionResult<Student>> PostTodo(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetStudent", new { id = student.Id }, student);
    }

        // ...
    // DELETE: api/MovieApi/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        var stud = await _context.Students.FindAsync(id);
        if (stud == null)
            return NotFound();

        _context.Students.Remove(stud);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}