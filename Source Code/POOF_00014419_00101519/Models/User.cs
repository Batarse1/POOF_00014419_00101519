namespace POOF_00014419_00101519.Models
{
    public class User
    {
        private string idUsuario;
        private string idDepartamento;
        private string contrasenia;
        private string nombre;
        private string apellido;
        private string dui;
        private string fechaNacimiento;

        public User(string idUsuario, string idDepartamento, string contrasenia, string nombre, string apellido, string dui, string fechaNacimiento)
        {
            this.idUsuario = idUsuario;
            this.idDepartamento = idDepartamento;
            this.contrasenia = contrasenia;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dui = dui;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string IdUsuario
        {
            get => idUsuario;
            set => idUsuario = value;
        }

        public string IdDepartamento
        {
            get => idDepartamento;
            set => idDepartamento = value;
        }

        public string Contrasenia
        {
            get => contrasenia;
            set => contrasenia = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public string Dui
        {
            get => dui;
            set => dui = value;
        }

        public string FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
    }
}