using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frCadEstacionamento : Form
    {   // 
        // variaveis global
        //  
        String FcodPlaca   = "";
        const string quote = "\"";

        public frCadEstacionamento()
        {
            InitializeComponent();
        }

        String TiraCaractereEspecial(String prMsk)
        {
            prMsk = prMsk.Replace("_", "");
            prMsk = prMsk.Replace("-", "");  
            prMsk = prMsk.Replace(":", ""); // Troca os valores com o paremetro do lado.

            return prMsk.Trim(); // remove os espacos em branco do campo.
        }

        void Limpar()
        {
            mskPlaca.Clear(); // limpa o campo.
            mskData.Clear();
            mskHoraChegada.Clear();
            mskHoraSaida.Clear();
            mskDuracao.Clear();
            txtTempoCobrado.Clear();
            txtValorPagar.Clear();
        }

        String InverteData()
        {
            String texto = mskData.Text;
            return texto = texto.Substring(6) + "-" + texto.Substring(3, 3) + texto.Substring(0, 2); 
            // inverte posição da data para que o Banco reconheça o formato antes de cadastrar.
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
                String strDataInvertida;

                strDataInvertida  = InverteData();

                Cadastro cadastro = new Cadastro(mskPlaca.Text, strDataInvertida, mskHoraChegada.Text,
                                                 mskHoraSaida.Text, mskDuracao.Text, txtTempoCobrado.Text, txtPreco.Text,
                                                 txtValorPagar.Text); // Chama a class Cadastro passando como parametro os
                                                                      // objetos pegando somente o texto.

                tvSisEstacio.DataSource = GetEstacionamento(); // pegar informações do banco e jogar no grid.

                MessageBox.Show(cadastro.mensagem); 

                Limpar();
        }

        void mudaNomeGridColuna()
        {
            tvSisEstacio.Columns[0].HeaderText = "Placa"; // Alterando o nome da coluna do grid passando a posição da coluna e a String.
            tvSisEstacio.Columns[1].HeaderText = "Data";
            tvSisEstacio.Columns[2].HeaderText = "Horarío de Chegada";
            tvSisEstacio.Columns[3].HeaderText = "Horarío de Saída";
            tvSisEstacio.Columns[4].HeaderText = "Duração";
            tvSisEstacio.Columns[5].HeaderText = "Tempo Cobrado";
            tvSisEstacio.Columns[6].HeaderText = "Preço";
            tvSisEstacio.Columns[7].HeaderText = "Valor a Pagar";
        }

        private void frCadEstacionamento_Load(object sender, EventArgs e)
        {
            tvSisEstacio.DataSource = GetEstacionamento(); // pegar informações do banco e jogar no grid.
            mudaNomeGridColuna(); 
        }

        void CalcValorPagar()
        {
            float floatTempoCobrado = float.Parse(txtTempoCobrado.Text); /// Parse tranformar o valor de String para Float, int ...
            txtValorPagar.Text      =  (floatTempoCobrado * 2).ToString();
            txtTempoCobrado.Text    = floatTempoCobrado.ToString().Replace(",", ".");
        }

        void CalcDuracao()
        {
            String[] horaChegada;
            String[] horaFim;
            horaChegada     = mskHoraChegada.Text.Split(":"); // Separa os valores pelo caracter atribuido no parametro.
            horaFim         = mskHoraSaida.Text.Split(":");
                                                              // TimeSpan server para lidar com tempo, formato de data, etc... 
            TimeSpan horaIni = new TimeSpan(Int32.Parse(horaChegada[0]), Int32.Parse(horaChegada[1]), Int32.Parse(horaChegada[2])); 
            TimeSpan horafinal = new TimeSpan(Int32.Parse(horaFim[0]), Int32.Parse(horaFim[1]), Int32.Parse(horaFim[2]));
            mskDuracao.Text    = horafinal.Subtract(horaIni).ToString(); // int32 para passar uma string para inteiro.
        }

        void CalcTempoCobrado()
        {
            String[] horaDuracao;

            horaDuracao = mskDuracao.Text.Split(":");

            TimeSpan horaDuracaoTime = new TimeSpan(Int32.Parse(horaDuracao[0]), (Int32.Parse(horaDuracao[1])), (Int32.Parse(horaDuracao[2])));
            TimeSpan umaHora         = new TimeSpan(01, 00, 00);

             
              // como o valor da hora é 0 entra na primeira condição calculando min 31<=30, valor 31 é maoir que 30 entra no senão = 1
              // como o valor da hora é 1 entra na segunda condição, como 0 não é maior que 10 retorna o valor de uma hora pois na regra de negocio 
            

            if (horaDuracaoTime.Hours == 0)  // como o valor da hora é 0 entra na primeira condição, dessa forma é certeza que temos menos de 1hr
            {                                           
                if (horaDuracaoTime.Minutes <= 30)//calcula min: X <= 30 = 0,5 meia hora
                {
                    txtTempoCobrado.Text = "0,5"; 
                    return;
                }
                else                             //Se min: X > 30 = 1 hora
                {
                    txtTempoCobrado.Text = "1";
                    return;
                }
            }
            else                                        //Se for maior ou igual a uma hora.
            {         
                if (horaDuracaoTime.Minutes > 10)   //calcula min: X > 10 então hora X = hora X + 1 hora.
                { 
                    horaDuracaoTime = horaDuracaoTime + umaHora; 
                }
            }
                                                          // retorna valor final.
            txtTempoCobrado.Text = horaDuracaoTime.Hours.ToString();

        }

        private DataTable GetEstacionamento()
        {
            MySqlCommand cmd = new MySqlCommand(); // chamando o a class do MySQL
            Conexao conexao  = new Conexao(); // Chamando class da Conexao 
            
            DataTable GetEstacionamento = new DataTable(); //Como se fosse uma tabela temporária.
           
            cmd.Connection   = conexao.conectar();                 // conectando com Banco
            cmd.CommandText  = "select * from cadestacionamento"; // Passando o comando SQL

            MySqlDataReader reader = cmd.ExecuteReader(); // executando o comando passado logo acima.
            GetEstacionamento.Load(reader); //Carrega as informações que veio do banco na tabela.

            conexao.desconectar();  // deconectando do banco.

            return GetEstacionamento;
        }

        private void mskHoraSaida_Leave(object sender, EventArgs e)
        {
            mskDuracao.Text = "00:00:00";      // valor inicialiado em 0 pois se o usuario não digitar o banco precisa de um valor para pegar.
            txtTempoCobrado.Text = "0";

            if (TiraCaractereEspecial(mskHoraSaida.Text) == "") 
            {
                mskHoraSaida.Text = "00:00:00"; //Fiz assim para dar a possbilidade de cadastrar um carro sem a hora de saída,
                                                //pois não da pra saber a hora de saída quando o cliente chega com seu carro no local.
                return;
            }

            CalcDuracao();        // Função para calcular a duração. subtraindo hora final com a hora inicial. 
            CalcTempoCobrado();   // Função para calcular o tempo cobrado de acordo com a duração. 
            CalcValorPagar();     // Função para calcular o valor a pagar de acordo com o tempo cobrado e o preço.
        }

        private void tvSisEstacio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar o valor da celula placa que seria nossa chave primaria do banco.
            FcodPlaca = tvSisEstacio.Rows[e.RowIndex].Cells[0].Value.ToString();
           
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                Conexao conexao  = new Conexao();

                cmd.Connection  = conexao.conectar();
                cmd.CommandText = ("delete from cadestacionamento where BDPLACA = " + quote + FcodPlaca + quote);
                 
                MySqlDataReader reader = cmd.ExecuteReader(); 

                conexao.desconectar();

                tvSisEstacio.DataSource = GetEstacionamento(); // atualizar grid apos ter deletado valor
                MessageBox.Show("Campo Deletado");
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possivel deletar o campo " + erro);
            }
                
        }

        private void mskPlaca_Leave(object sender, EventArgs e)
        {
            if (TiraCaractereEspecial(mskPlaca.Text) == "") // Fazer com que o usuario não deixe o campo em branco.
            {
                MessageBox.Show("Esse campo é obrigatório!");    
                mskPlaca.Focus(); // Faz com que volte no campo para o usuario digitar algum valor.
            }
        }

        private void mskData_Leave(object sender, EventArgs e)
        {
            if (TiraCaractereEspecial(mskData.Text) == "")
            {
                MessageBox.Show("Esse campo é obrigatório!");
                mskData.Focus();
            }
        }

        private void mskHoraChegada_Leave(object sender, EventArgs e)
        {
            if (TiraCaractereEspecial(mskHoraChegada.Text) == "")
            {
                MessageBox.Show("Esse campo é obrigatório!"); 
                mskHoraChegada.Focus();
            }
        }
    }
}

