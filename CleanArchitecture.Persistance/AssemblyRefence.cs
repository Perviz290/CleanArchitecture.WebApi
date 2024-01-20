using System.Reflection;

namespace CleanArchitecture.Persistance;

public static class AssemblyRefence
{
    public static readonly Assembly Assembly=typeof(Assembly).Assembly;

    //Configuration folderin butun classlari gormek ucun AssemblyRefence Classi=>
    // AppDbContext e tanitmaq lazimdir

    //ForExample => protected override void OnModelCreating(ModelBuilder modelBuilder) =>
    //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyRefence).Assembly);
    //bunu appDbContext e yazmaq lazimdir
}
