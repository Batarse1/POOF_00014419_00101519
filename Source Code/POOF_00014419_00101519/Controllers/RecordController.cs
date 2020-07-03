using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using Npgsql;
using POOF_00014419_00101519.Models;

namespace POOF_00014419_00101519.Controlers
{
    
    public static class RecordController
    {
        public static DataTable RecordTableId(int i)
        {
            DataTable dataTable = null;
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = $"SELECT r.entrada,r.fecha,r.tiempo,r.temperatura FROM registro r WHERE idusuario = {i}";
                dataTable = proxy.IExecuteQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return dataTable;
        }

        public static string TopTemperatureID(int i)
        {
            string s = "\0";
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = $"SELECT r.entrada,r.fecha,r.tiempo,r.temperatura FROM registro r WHERE idusuario = {i} ORDER BY temperatura DESC LIMIT 1";
                DataTable dataTable = proxy.IExecuteQuery(sql);
                foreach (DataRow dr in dataTable.Rows)
                {
                    s = dr[3].ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            return s;
        }
        
        public static DataTable RecordTable()
        {
            DataTable dataTable = null;
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = "SELECT * FROM registro";
                dataTable = proxy.IExecuteQuery(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return dataTable;
        }

        
        public static List<double> TopRecordList()
        {
            List<double> list = new List<double>();
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = "SELECT * FROM REGISTRO r ORDER BY r.temperatura DESC LIMIT 5";
                DataTable dataTable = proxy.IExecuteQuery(sql);
                foreach(DataRow dr in dataTable.Rows)
                {
                    list.Add(Convert.ToDouble(dr[5]));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return list;
        }

        public static void AddRecord(int idUsuario, bool entrada, DateTime fecha, DateTime tiempo, double temperatura)
        {
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = $"INSERT INTO REGISTRO(idUsuario,entrada,fecha,tiempo,temperatura) VALUES ({idUsuario},{entrada},'{fecha}','{tiempo}',{temperatura})";
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