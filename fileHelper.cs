public static class fileHelper
{
    public static void crearCSV(string _ruta, string _curso){
    
        if (Directory.Exists(_ruta))
        {
            FileStream fileStream;

            if (!File.Exists(_ruta + @$"\{_curso}.csv"))
            {
                Console.WriteLine("Creando archivo csv...");
                fileStream = File.Create(_ruta + @$"\{_curso}.csv");
                fileStream.Close();

            }

            var archivo = new FileStream(_ruta + @$"\{_curso}.csv", FileMode.Truncate);
            string cadena = "ID;NOMBRE;APELLIDO;DNI\n";

            StreamWriter escribir = new StreamWriter(archivo);
            escribir.Write(cadena);
            escribir.Close();
            archivo.Close();
            
        }
        else
        {
            Console.WriteLine("La ruta ingresada no existe");

        }

    }

    public static void escribirContenido(string _ruta, string _curso, Alumno _alumno)
    {
        if (File.Exists(_ruta + @$"\{_curso}.csv"))
        {
            StreamWriter file = new StreamWriter(_ruta + @$"\{_curso}.csv", true);

            file.WriteLine($"{_alumno.IdAlumno};{_alumno.Nombre};{_alumno.Apellido};{_alumno.Dni}");
            file.Close();

        }

    }

    public static void leerCSV(string _ruta, string _curso)
    {
        if (File.Exists(_ruta + @$"\{_curso}.csv"))
        {
            StreamReader file = new StreamReader(_ruta + @$"\{_curso}.csv");
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }
            file.Close();

        }

    }
    
    public static void limpiarContenido(string _ruta, string _curso)
    {
        if (Path.GetFileName(_ruta + @$"\{_curso}.csv").Split('.')[1] == "csv")
        {
            File.Delete(_ruta + @$"\{_curso}.csv");
            
        }

    }

}