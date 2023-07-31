using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hastaneRandevuSistemi.Models.city
{
    public class cityContext
    {

        con = new SqlConnection("Data Source=DESKTOP-O4KIT93\\SQLEXPRESS;Initial Catalog=stajproje2;Integrated Security=True");

        public DbSet<il> ils { get; set; }
        SqlConnection con;
        SqlCommand cmd;
    }

    public List<il> ilGetir()
    {
        List<il> ilListesi = new List<il>();
        string sql = "SELECT * FROM il";
        con.Open();
        cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            city il = new il();
            city.city_ID = Convert.ToInt32(dr[0]);
            city.City = dr[1].ToString();
            ilListesi.Add(il);
        }
        con.Close();
        return ilListesi;
    }
}
