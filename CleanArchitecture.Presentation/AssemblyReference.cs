using System.Reflection;

namespace CleanArchitecture.Presentation
{
    public static class AssemblyReference
    {

        public static readonly Assembly Assembly=typeof(Assembly).Assembly;

        //Bu assembly reference Web Api projectin program.cs file na bildirmek lazmdirki->
        //Presentation icindeki Controlleri Web Api projectimiz gorsun 

        //builder.Services.AddControllers().AddApplicationPart(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);
        // bunu program.cs e yazmaq lazimdir ki Burda olan butun Controlleri gorsun\

    }
}
