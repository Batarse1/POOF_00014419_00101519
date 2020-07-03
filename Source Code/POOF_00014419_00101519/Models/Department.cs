namespace POOF_00014419_00101519.Models
{
    public class Department
    {
        private string idDepartamento;
        private string nombre;
        private string ubicacion;

        public Department(string idDepartamento, string nombre, string ubicacion)
        {
            this.idDepartamento = idDepartamento;
            this.nombre = nombre;
            this.ubicacion = ubicacion;
        }

        public string IdDepartamento
        {
            get => idDepartamento;
            set => idDepartamento = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Ubicacion
        {
            get => ubicacion;
            set => ubicacion = value;
        }
    }
}