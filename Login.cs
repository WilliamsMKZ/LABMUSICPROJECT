using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LABMUSIC
{
    public partial class Login : Form
    {


        MySqlConnection conn = new MySqlConnection("server = localhost; userid = root; password = usbw; port = 3307; database =bd_musicas; ");
        int i;

        public Login()
        {
            InitializeComponent();
        }

     


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotãoEntrar_Click(object sender, EventArgs e)
        {
            i = 0;
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tabela_dados where usuario='" + TxtNome2.Text + "' and senha='" + TxtSenha2.Text + "' ";
            cmd.ExecuteNonQuery();

            DataTable dtt = new DataTable();
            MySqlDataAdapter daa = new MySqlDataAdapter(cmd);
            daa.Fill(dtt);
            i = Convert.ToInt32(dtt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Usuário e Senha Incorreto !");
            }
            else
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            conn.Close();

            if (TxtNome2.Text == "" || TxtSenha2.Text == "")
            {
                MessageBox.Show("Preencha os Campos Vazios !");
            }
        }


    }
}
