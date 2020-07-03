using System;

namespace POOF_00014419_00101519.Models
{
    public class Record
    {
        private string idUsuario;
        private string entrada;
        private string fecha;
        private string tiempo;
        private string temperatura;

        public Record(string idUsuario, string entrada, string fecha, string tiempo, string temperatura)
        {
            this.idUsuario = idUsuario;
            this.entrada = entrada;
            this.fecha = fecha;
            this.tiempo = tiempo;
            this.temperatura = temperatura;
        }

        public Record(string idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public string IdUsuario
        {
            get => idUsuario;
            set => idUsuario = value;
        }

        public string Entrada
        {
            get => entrada;
            set => entrada = value;
        }

        public string Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        public string Tiempo
        {
            get => tiempo;
            set => tiempo = value;
        }

        public string Temperatura
        {
            get => temperatura;
            set => temperatura = value;
        }
    }
}