using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2


{   public class Cadastro
    {
        Conexao conexao = new Conexao();
        public String mensagem = "";
        const string quote = "\"";

        bool pkExistente(String Placa) 
        {
            MySqlCommand obj = conexao.conectar().CreateCommand(); 
            MySqlDataReader dr;

            bool wExistePlaca = false;

            //Usei o quote aqui para que o número da placa ficasse entre aspas, porque no banco ele é um varchar e se não tiver entre aspas vai dar erro.
            obj.CommandText = " select BDPLACA from cadestacionamento where BDPLACA = " + quote + Placa + quote; 

            try
            {
                obj.Connection = conexao.conectar(); //conecta no banco

                dr = obj.ExecuteReader(); //Lê o nosso SQL ali de cima
                
                while (dr.Read()) 
                {
                    //Se a placa que o usuário digitou for a mesma que o nosso select retornou então precisa fazer updte
                    // e retorna TRUE

                    if (dr.GetString(0) == Placa)
                    {
                        wExistePlaca = true;
                    }
                }

                conexao.desconectar(); //Desconecta do banco
                return wExistePlaca;
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao se conectar com banco de dados";

                conexao.desconectar(); //Desconecta do banco
                return wExistePlaca;          
            } 
        }   

        public Cadastro(String prPlaca, String prData, String prHoraChegada, String prHoraSaida, String prDuracao, String prTempoCobrado, String prPreco, String prValorPagar)
        {
            bool update = false;

            //Esse método retorna se a placa que o usuário digitou no banco existe, caso exista o método retorna
            //um bool, informando que deve ser realizado um UPDATE, caso seja false, será feito o insert.
            update = pkExistente(prPlaca); 

            var cmd = conexao.conectar().CreateCommand();

            if (!update)
            {
                cmd.CommandText = "insert into cadestacionamento (BDPLACA, BDDATA, BDHORAENTRADA, BDHORASAIDA, " +
                                                                 "BDDURACAO, BDTEMPOCOBRADO, BDPRECO, BDVALORPAGAR) " +
                                  "Values(@prPlaca, @prData, @prHoraChegada, @prHoraSaida, @prDuracao, " +
                                  "       @prTempoCobrado, @prPreco, @prValorPagar)";
            }
            else
            {
                
                cmd.CommandText = " update cadestacionamento set BDPLACA = @prPlaca, BDDATA = @prData, BDHORAENTRADA = @prHoraChegada, " +
                                  " BDHORASAIDA = @prHoraSaida, BDDURACAO = @prDuracao, BDTEMPOCOBRADO = @prTempoCobrado, " +
                                  " BDPRECO = @prPreco, BDVALORPAGAR = @prValorPagar where BDPLACA = @prPlaca";
            }

            // Passado um parametro em String para pegar o valor digitado ao lado.

            cmd.Parameters.AddWithValue("@prPlaca", prPlaca);
            cmd.Parameters.AddWithValue("@prData", prData);
            cmd.Parameters.AddWithValue("@prHoraChegada", prHoraChegada);  
            cmd.Parameters.AddWithValue("@prHoraSaida", prHoraSaida); 
            cmd.Parameters.AddWithValue("@prDuracao", prDuracao);
            cmd.Parameters.AddWithValue("@prTempoCobrado", prTempoCobrado);
            cmd.Parameters.AddWithValue("@prPreco", prPreco);
            cmd.Parameters.AddWithValue("@prValorPagar", prValorPagar);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                this.mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException e) 
            {
                 this.mensagem = "Erro ao se conectar com banco de dados";
            }
        }
    }
}
