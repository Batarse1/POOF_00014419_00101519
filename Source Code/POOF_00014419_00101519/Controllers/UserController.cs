using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using POOF_00014419_00101519.Models;

namespace POOF_00014419_00101519.Controlers
{
    public static class UserController
    {
        public static List<User> UserList()
        {
            List<User> list = new List<User>();
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = "SELECT * FROM USUARIO";
                DataTable dataTable = proxy.IExecuteQuery(sql);
                foreach(DataRow dr in dataTable.Rows)
                {
                    list.Add(new User(dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),dr[4].ToString(),dr[5].ToString(),dr[6].ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            return list;
        }

        public static void RemoveUser(int i)
        {
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = $"DELETE FROM USUARIO WHERE idusuario = {i}";
                proxy.IExecuteNonQuery(sql);
                MessageBox.Show("Se ha eliminado exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error, debe de borrar los registros del usuario antes de borrar al usuario");
            }
        }

        public static void AddUser(int idDepartamento, string contrasenia, string nombre, string apellido, string dui, DateTime fechaNacimiento)
        {
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = $"INSERT INTO USUARIO(idDepartamento,contrasenia,nombre,apellido,dui,fechanacimiento) VALUES ({idDepartamento},'{contrasenia}','{nombre}','{apellido}','{dui}','{fechaNacimiento}');";
                proxy.IExecuteNonQuery(sql);
                MessageBox.Show("Se ha agregado exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}