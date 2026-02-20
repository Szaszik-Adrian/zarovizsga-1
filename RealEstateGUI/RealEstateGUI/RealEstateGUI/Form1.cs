using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;


namespace RealEstateGUI
{
    public partial class Form1 : Form
    {
        private List<Seller> sellers = new List<Seller>();
        public Form1()
        {
            InitializeComponent();
            lbSellers.SelectedIndexChanged += LbSellers_SelectedIndexChanged;
            btnLoadAds.Click += BtnLoadAds_Click;

            LoadSellers();
        }

        private void LoadSellers()
        {
            sellers.Clear();

            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT id, name, phone FROM sellers ORDER BY name;";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        sellers.Add(new Seller
                        {
                            Id = r.GetInt32("id"),
                            Name = r.GetString("name"),
                            Phone = r.GetString("phone")
                        });
                    }
                }
            }

            lbSellers.DataSource = null;
            lbSellers.DataSource = sellers;
        }

        private void LbSellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSellers.SelectedItem is Seller s)
            {
                lblSellerName.Text = s.Name;
                lblSellerPhone.Text = s.Phone;
                lblAdsCount.Text = "0";
            }
        }

        private void BtnLoadAds_Click(object sender, EventArgs e)
        {
            var s = lbSellers.SelectedItem as Seller;
            if (s == null) return;

            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM realestates WHERE SellerId = @id;";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", s.Id);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    lblAdsCount.Text = count.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSellerName.Location = new Point(430, 30);
            lblSellerPhone.Location = new Point(430, 60);
        }
    }
}
