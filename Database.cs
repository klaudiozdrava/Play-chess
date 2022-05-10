using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace chessTeliki
{
    public class Database
    {
       public  Database(string user1,string user2,string date)
        {
            
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ergasiesAAE\chessTeliki\DATABASE1.MDF;Integrated Security = True; Connect Timeout = 30;");
            String insertQuery = "INSERT INTO DATACHESS(FirstUser,SecondUser,Date) VALUES('" + user1 + "','" + user2 + "','" + date + "');";
            SqlDataAdapter sda = new SqlDataAdapter(insertQuery, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
        }
    }
}
