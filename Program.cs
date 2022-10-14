using NLog;

NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

Console.Clear();
Console.Write("Ingrese la cantidad de alumnos: ");
int cantidadAlumnos = int.Parse(Console.ReadLine());

List<Alumno> alumnos = new List<Alumno>();
string[] tipoCursos = {"atletismo", "voley", "futbol"};
string ruta = @".";

foreach (var item in tipoCursos)
{
    fileHelper.crearCSV(ruta, item);
}

for (int i = 0; i < cantidadAlumnos; i++)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"CARGUE LOS DATOS DEL ALUMNO {i+1}: ");
    System.Console.WriteLine();

    int idAlumno = i;
    
    Console.WriteLine("Ingrese el nombre: ");
    string nombre = functions.ingresarString();
    
    Console.WriteLine("Ingrese el apellido: ");
    string apellido = functions.ingresarString();
    
    Console.WriteLine("Ingrese el DNI: ");
    int dni = functions.ingresarPositivo();
    
    System.Console.WriteLine("Ingrese el deporte que realiza: ");
    System.Console.WriteLine("0 - Atetismo");
    System.Console.WriteLine("1 - Voley");
    System.Console.WriteLine("2 - Futbol");
    int curso = functions.ingresarPositivo();

    alumnos.Insert(i, new Alumno(idAlumno, nombre, apellido, dni, curso));
    Logger.Info("Alumno guardado");

    fileHelper.escribirContenido(ruta, tipoCursos[curso], alumnos[i]);
    Logger.Debug("CSV escrito");
    
}