public class Alumno
{
    private int idAlumno;
    private string nombre;
    private string apellido;
    private int dni;
    private int curso;

    public int IdAlumno { get => idAlumno; set => idAlumno = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int Dni { get => dni; set => dni = value; }
    public int Curso { get => curso; set => curso = value; }

    public Alumno()
    {

    }

    public Alumno(int _idAlumno, string _nombre, string _apellido, int _dni, int _curso)
    {
        IdAlumno = _idAlumno;
        Nombre = _nombre;
        Apellido = _apellido;
        Dni = _dni;
        Curso = _curso;
    
    }

}