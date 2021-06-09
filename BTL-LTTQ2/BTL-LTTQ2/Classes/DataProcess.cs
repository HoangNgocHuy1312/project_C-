using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTL_LTTQ2.Classes
{
    class DataProcess
    {
        string strConnect = "Data Source=ADMIN\\SQLEXPRESS01; DataBase=QLXeMay; Integrated Security=true";
        SqlConnection sqlconnect = null;

        // Phương thức mở kết nối
        void OpenConnect()
        {
            sqlconnect = new SqlConnection(strConnect);
            if (sqlconnect.State != ConnectionState.Open)
            {
                sqlconnect.Open();
            }
        }

        // Phương thức đóng kết nối
        void CloseConnect()
        {
            if (sqlconnect.State != ConnectionState.Closed)
            {
                sqlconnect.Close();
                sqlconnect.Dispose();
            }
        }

        // Phương thức thực hiện lệnh select trả về data table
        public DataTable DataReader(string sqlselect)
        {
            DataTable datatable = new DataTable();
            OpenConnect();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlselect, sqlconnect);
            adapter.Fill(datatable);
            CloseConnect();
            return datatable;
        }

        // Phương thức thực hiện các lệnh thay đổi dữ liệu 
        public void DataChanger(String sql)
        {
            OpenConnect();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlconnect;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            CloseConnect();
        }

        public object ExcuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, sqlconnect);
            OpenConnect();
            object ketqua = comm.ExecuteScalar();
            CloseConnect();
            return ketqua;

        }
    }
}
