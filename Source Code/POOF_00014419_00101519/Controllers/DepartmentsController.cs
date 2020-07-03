using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using POOF_00014419_00101519.Models;

namespace POOF_00014419_00101519.Controlers
{
    public static class DepartmentsController
    {
        public static List<Department> DepartmentsList()
        {
            List<Department> list = new List<Department>();
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = "SELECT * FROM DEPARTAMENTO";
                DataTable dataTable = proxy.IExecuteQuery(sql);
                foreach(DataRow dr in dataTable.Rows)
                {
                    list.Add(new Department(dr[0].ToString(),dr[1].ToString(),dr[2].ToString()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            return list;
        }

        public static string topDepartment()
        {
            string s = "";
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = "SELECT d.nombre, count(u.idDepartamento) as frecuencia FROM REGISTRO r, DEPARTAMENTO d, USUARIO u WHERE r.idUsuario = u.idUsuario AND d.idDepartamento = u.idDepartamento GROUP BY d.idDepartamento ORDER BY frecuencia DESC LIMIT 1";
                DataTable dataTable = proxy.IExecuteQuery(sql);
                foreach(DataRow dr in dataTable.Rows)
                {
                    s = dr[0].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            return s;
        }
    }
}