using Microsoft.EntityFrameworkCore;
using OnePieceApi.Models;

namespace OnePieceApi.Data;

public class OnePieceDbContext : DbContext
{
    public OnePieceDbContext(DbContextOptions<OnePieceDbContext> options)
        : base(options)
    {
    }

    public DbSet<Character> Characters { get; set; }
}