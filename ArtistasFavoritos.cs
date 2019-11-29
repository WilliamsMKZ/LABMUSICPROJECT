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


    public partial class ArtistasFavoritos : Form
    {
        private object TxtId;
        private object Txtartista;
        private object Txtgenero;
        private object Txtalbum;

        private void FiltrarDados()
        {

        }

        string connectionString = @"server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw";
        int musicaID = 0;
    

        public ArtistasFavoritos()
        {
            InitializeComponent();
        }

        private void ArtistasFavoritos_Load(object sender, EventArgs e)
        {

        }

        private void BtnVoltar2_Click(object sender, EventArgs e)
        {            
            Menu menu = new Menu();
            menu.Show();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            // passa a string de conexão
            MySqlConnection objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw");
            // abre o banco de dados
            objcon.Open();
            MessageBox.Show("Artista Adicionado Com Sucesso !");
            //comando sql para inserir dados na tabela
            MySqlCommand objCmd = new MySqlCommand("insert into tabela_artista (id_artista, artista, genero, album) Values (null, ? , ? , ?); ", objcon);
            objCmd.Parameters.Add("@artista", MySqlDbType.VarChar, 30).Value = TxtArtista.Text;
            objCmd.Parameters.Add("@genero", MySqlDbType.VarChar, 30).Value = TxtGenero.Text;
            objCmd.Parameters.Add("@album", MySqlDbType.VarChar, 30).Value = TxtAlbum.Text;

            // comando para executar query
            objCmd.ExecuteNonQuery();

            //fecha conexão
            objcon.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // passa a string de conexão
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw");
                // abre o banco de dados
                objcon.Open();
                // comando do mysql com seus parametros
                MySqlCommand objCmd = new MySqlCommand("delete from tabela_artista where id_artista = ?",objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@id_artista", MySqlDbType.Int32).Value = TxtID.Text;

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

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Txtartista = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            Txtgenero = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Txtalbum = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void idlabel_Click(object sender, EventArgs e)
        {
            string id_artista = TxtID.Text;
            string artista = TxtArtista.Text;
            string genero = TxtGenero.Text;
            string album = TxtAlbum.Text;



            if (artista == "" || genero == "" || album == "")
            {
                MessageBox.Show("você não pode deixar os campos vazios", "ERRO");
                return;
            }

            string Configuracao = "server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            try
            {
                Conexao.Open();
                MySqlCommand COMANDOS = new MySqlCommand("INSERT INTO tabela_artista (id_artista,artista, genero , album)" + "VALUES ('" + id_artista + "','" + artista + "','" + genero + "','" + album + "')", Conexao);
                COMANDOS.ExecuteNonQuery();

                MessageBox.Show("Informações registrada com sucesso no banco de dados!", "Dados registrados!");


            }
            catch
            {
                MessageBox.Show("Não foi possivel registrar as informações no banco de dados", "ERRO de conexao");
            }
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            ClasseBLLLLL bll = new ClasseBLLLLL();

            try
            {
                dataGridView1.DataSource = bll.exibirdadosdal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro ao exibir os dados" + erro); //mensagem de erro caso o problema seja nesse setor
            }
        }

        private void BtnBuscar_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
