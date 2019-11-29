﻿using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace LABMUSIC
{
    class ClasseDALL
    {
        string Configuracao = "server=localhost;port=3307;User Id=root;database=bd_musicas; password=usbw";
        MySqlConnection conexao = null;
        MySqlCommand comando;

        public DataTable exibirDados()
        { //string de select para selexao no banco de dados
            try
            {
                conexao = new MySqlConnection(Configuracao);
                comando = new MySqlCommand("SELECT * FROM tabela_eventos", conexao);

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = comando;
                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
