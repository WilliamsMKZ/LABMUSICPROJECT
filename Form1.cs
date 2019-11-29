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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
           

            InitializeComponent();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void paneLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // inserido
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void BotãoRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                // passa a string de conexão
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw");
                // abre o banco de dados
                objcon.Open();
                MessageBox.Show("Cadastro Realizado com Sucesso ! Prossiga para a pagina de Login");
                //comando sql para inserir dados na tabela
                MySqlCommand objCmd = new MySqlCommand("insert into tabela_dados (cd_dados, usuario, senha, rptsenha, email) Values (null, ? , ? , ? , ?); ",objcon);
                objCmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 30).Value = TxtNome.Text;
                objCmd.Parameters.Add("@senha", MySqlDbType.VarChar, 30).Value = TxtSenha.Text;
                objCmd.Parameters.Add("@rptsenha", MySqlDbType.VarChar, 30).Value = TxtRepetirSenha.Text;
                objCmd.Parameters.Add("@email", MySqlDbType.VarChar, 30).Value = TxtEmail.Text;

                // comando para executar query
                objCmd.ExecuteNonQuery();
                
                //fecha conexão
                objcon.Close();

                this.Hide();
                Login login = new Login();
                login.Show();

            }

            catch
            {
                MessageBox.Show("Registro Malsucessido");
            }

                   
            
            

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
