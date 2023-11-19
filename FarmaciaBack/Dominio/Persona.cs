namespace FarmaciaBack.Dominio
{
    public class Persona
    {
        private int id_pers;
        private string apellido;
        private string nombre;
        private int dni;
        private DateTime fecha_nacimiento;
        private string sexo;
        private string direccion;
        private List<Contacto> contacto;
        public int Id_pers
        {
            get { return id_pers; }
            set { id_pers = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public DateTime Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public List<Contacto> Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }

        public Persona(int id_pers, string apellido, string nombre, int dni, DateTime fec_nac, string sexo, string direc, List<Contacto> contacto)
        {
            Id_pers = id_pers;
            Apellido = apellido;
            Nombre = nombre;
            Dni = dni;
            Fecha_nacimiento = fec_nac;
            Sexo = sexo;
            Direccion = direc;
            Contacto = contacto;
        }

        public Persona(int id_pers, string apellido, string nombre, List<Contacto> contacto)
        {
            Id_pers = id_pers;
            Apellido = apellido;
            Nombre = nombre;
            Contacto = contacto;
        }
        public Persona(int id_pers, string apellido, string nombre)
        {
            Id_pers = id_pers;
            Apellido = apellido;
            Nombre = nombre;
            Contacto = new List<Contacto>();
        }
        public Persona()
        {
            Contacto = new List<Contacto>();
        }

        public void AgregarContacto(Contacto c)
        {
            Contacto.Add(c);
        }

        public void QuitarContacto(int indice)
        {
            Contacto.RemoveAt(indice);
        }

        public override string ToString()
        {
            return Dni + "- " + Apellido + ", " + Nombre;
        }
    }
}