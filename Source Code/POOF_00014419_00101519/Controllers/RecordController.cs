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
        public static DataTable RecordTable()
        {
            DataTable dataTable = null;
            try
            {
                Connection.IProxy proxy = new Connection.proxyA();
                string sql = "SELECT r.entrada,r.fecha,r.tiempo,r.temperatura FROM registro r WHERE idusuario = 1";
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
                string sql = "SELECT * FROM REGISTRO r WHERE idusuario = 1 ORDER BY r.temperatura DESC LIMIT 3";
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
    }
}