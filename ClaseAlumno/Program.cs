using ClaseAlumno;

List<Alumno> lista = new List<Alumno>();

Alumno alumno1 = new Alumno();
alumno1.Nombres = "Hector";
alumno1.ApellidoPaterno = "Favela";
alumno1.Matricula = "01234";
alumno1.FechaNacimiento = new DateTime(2001, 11, 23);


Alumno alumno2 = new Alumno();
alumno2.Nombres = "Luis";
alumno2.ApellidoPaterno = "Ramirez";
alumno2.Matricula = "56789";
alumno2.FechaNacimiento = new DateTime(1980, 02, 28);

Alumno alumno3 = new Alumno();
alumno2.Nombres = "Jose";
alumno2.ApellidoPaterno = "Rodriguez";
alumno2.Matricula = "56789";
alumno2.FechaNacimiento = new DateTime(2002, 03, 15);

lista.Add(alumno1);
lista.Add(alumno2);
lista.Add(alumno3);

foreach (Alumno alumnoEnLista in lista)
{
    Console.WriteLine(
        " Nombre: "
        + alumnoEnLista.NombreCompleto
        + " Matricula: "
        + alumnoEnLista.Matricula
        + " fecha nacimiento: "
        + alumnoEnLista.FechaNacimiento.ToString("dd-MM-yyyy"));
}