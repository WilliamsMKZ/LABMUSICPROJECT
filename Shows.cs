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
    public partial class Shows : Form
    {

        private object TxtId2;
        private object Txtbanda;
        private object Txtdia;
        private object Txtlocalizacao;
        private object Txtvalor;


        public Shows()
        {
            InitializeComponent();
        }

        private void Shows_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnVoltar1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnAdicionar2_Click(object sender, EventArgs e)
        {
            // passa a string de conexão
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw");
            // abre o banco de dados
            objcon.Open();
            MessageBox.Show("Evento Adicionado Com Sucesso ! ");
            //comando sql para inserir dados na tabela
            MySqlCommand objCmd = new MySqlCommand("insert into tabela_eventos (id_eventos, artistas, dia_Mes, localizacao, valor) Values (null, ? , ? , ? , ?); ", objcon);
            objCmd.Parameters.Add("@artistas", MySqlDbType.VarChar, 30).Value = TxtBanda.Text;
            objCmd.Parameters.Add("@diames", MySqlDbType.VarChar, 30).Value = TxtDia.Text;
            objCmd.Parameters.Add("@localizacao", MySqlDbType.VarChar, 30).Value = TxtLocalizacao.Text;
            objCmd.Parameters.Add("@valor", MySqlDbType.VarChar, 30).Value = TxtValor.Text;

            // comando para executar query
            objCmd.ExecuteNonQuery();

            //fecha conexão
            objcon.Close();
        }

        private void BtnEditar2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluir2_Click(object sender, EventArgs e)
        {
            try
            {
                // passa a string de conexão
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw");
                // abre o banco de dados
                objcon.Open();
                // comando do mysql com seus parametros
                MySqlCommand objCmd = new MySqlCommand("delete from tabela_eventos where id_eventos = ?", objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@id_eventos", MySqlDbType.Int32).Value = TxtID2.Text;

                objCmd.CommandType = CommandType.Text;
                objCmd.ExecuteNonQuery();
                objcon.Close();
                MessageBox.Show("Registro Excluido Com Sucesso ! ");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi Possivel Excluir !" + erro);
            }
        }

        private void BtnAtualizar2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExibir2_Click(object sender, EventArgs e)
        {
            ClasseBLLL blll = new ClasseBLLL();

            try
            {
                dataGridView2.DataSource = blll.exibirdadosdal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro ao exibir os dados" + erro); //mensagem de erro caso o problema seja nesse setor
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId2 = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Txtbanda = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            Txtdia = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Txtlocalizacao = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            Txtvalor = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }

        private void idlabel2_Click(object sender, EventArgs e)
        {
            string id_eventos = TxtID2.Text;
            string artistas = TxtBanda.Text;
            string dia_mes = TxtDia.Text;
            string localizacao = TxtLocalizacao.Text;
            string valor = TxtValor.Text;



            if (artistas == "" || dia_mes == "" || localizacao == "" || valor == "")
            {
                MessageBox.Show("você não pode deixar os campos vazios", "ERRO");
                return;
            }

            string Configuracao = "server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            try
            {
                Conexao.Open();
                MySqlCommand COMANDOS = new MySqlCommand("INSERT INTO tabela_eventos (id_eventos,artistas, dia_mes , localizacao, valor)" + "VALUES ('" + id_eventos + "','" + artistas + "','" + dia_mes + "','" + localizacao + "','" + valor + "')", Conexao);
                COMANDOS.ExecuteNonQuery();

                MessageBox.Show("Informações registrada com sucesso no banco de dados!", "Dados registrados!");


            }
            catch
            {
                MessageBox.Show("Não foi possivel registrar as informações no banco de dados", "ERRO de conexao");
            }
        }
    }
}
