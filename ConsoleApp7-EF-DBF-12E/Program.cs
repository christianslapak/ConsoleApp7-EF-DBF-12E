using ConsoleApp7_EF_DBF_12E.Modelo;
using System;
using System.Linq;

namespace ConsoleApp7_EF_DBF_12E
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new Modelo.SchoolDBContext();


            //var nuevoEstudiante = new Student()
            //{
            //    StudentName = "Manuela",
            //    StandardId = 1
            //};
            //contexto.Student.Add(nuevoEstudiante);
            //contexto.SaveChanges();

            //Console.WriteLine("Estudiante agregado!");
            //Console.ReadKey();

            //var consulta = contexto.Student.Where(s => s.StudentId == 1012);
            //var estudianteConsulta = consulta.FirstOrDefault<Student>();
            //Console.WriteLine("Encontré al estudiante 2 y se llama " + estudianteConsulta.StudentName);
            //Console.ReadKey();

            //var cons = from st in contexto.Student where st.StudentName == "Fernando" select st;
            //var estu = cons.FirstOrDefault<Student>();
            //Console.WriteLine("Encontré a Fernando y tiene el Id " + estu.StudentId);
            //Console.ReadKey();

            var listaEstudiantes = contexto.Student.ToList<Student>();
            //Student estudianteActualizado = listaEstudiantes.Where(s => s.StudentId == 2).FirstOrDefault<Student>();
            //estudianteActualizado.StudentName = "Armando";
            //Console.WriteLine("El estudiante de Id 2 ahora se llama Armando");
            
            //contexto.Student.Remove(listaEstudiantes.ElementAt<Student>(3));
            //Console.WriteLine("Estudiante en la posicion 3 - eliminado");
            //contexto.SaveChanges();
            //Console.ReadKey();

        }
    }
}
