using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using static FolhaDePagamento.CadFunc;



namespace FolhaDePagamento
{
    internal class managcad
    {
        public class Cadastro
        {
            public string matricula = "";
            public string nome = "";
            public string cpf = "";
            public string dtnasc = "";
            public string telef = "";
            public string endereco = "";
            public string cep = "";
            public string num = "";
            public string bairro = "";
            public string cargo = "";
            public string email = "";
            public string nomeempresa = "";
            public string cnpj = "";
            public string sexo = "";
            public string ativo = "";

            //Método construtor?
                      
            public Cadastro(string matricula, string nome, string cpf, string dtnasc, string telef, string endereco, string cep, string num, string bairro, string cargo, string email, string nomeempresa, string cnpj, string sexo, string ativo)
            {
                this.matricula = matricula;
                this.nome = nome;
                this.cpf = cpf;
                this.dtnasc = dtnasc;
                this.telef = telef;
                this.endereco = endereco;
                this.cep = cep;
                this.num = num;
                this.bairro = bairro;
                this.cargo = cargo;
                this.email = email;
                this.nomeempresa = nomeempresa;
                this.cnpj = cnpj;
                this.sexo = sexo;
                this.ativo = ativo;
            }
            public Cadastro()
            {

            }
        }

        public class DMC
        {
            //Classe Consulta, tem como parametro para consultar a Matricula
            public Cadastro Consulta(string matricula)
            {
                Cadastro cade = new Cadastro(); //Chama a classe Cadastro para usar as variáveis

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3D2GOF3\SQLEXPRESS; Initial catalog=DB_PIM; Integrated Security=true";
                con.Open(); 

                SqlCommand cdm = new SqlCommand();

                cdm.Connection = con; 
                cdm.CommandText = "SELECT nome_func, matricula, cpf, cargo, email_func, dtNasc_func, sexo_func, nome_empresa, cnpj_empresa, endereco, numero, cep, bairro, telefone " +
                    "FROM TB_Funcionario WHERE (ativo = '1') AND (matricula ='" + matricula + "')";

                SqlDataReader cdmReader = cdm.ExecuteReader();

                if (cdmReader.Read()) //atribui nas variáveis os valores consultados no banco de dados.
                {
                    cade.nome = cdmReader["nome_func"].ToString();
                    cade.matricula = cdmReader["matricula"].ToString();
                    cade.cpf = cdmReader["cpf"].ToString();
                    cade.cargo = cdmReader["cargo"].ToString();
                    cade.email = cdmReader["email_func"].ToString();
                    cade.dtnasc = cdmReader["dtNasc_func"].ToString();
                    cade.sexo = cdmReader["sexo_func"].ToString();
                    cade.nomeempresa = cdmReader["nome_empresa"].ToString();
                    cade.cnpj = cdmReader["cnpj_empresa"].ToString();
                    cade.endereco = cdmReader["endereco"].ToString();
                    cade.num = cdmReader["numero"].ToString();
                    cade.cep = cdmReader["cep"].ToString();
                    cade.bairro = cdmReader["bairro"].ToString();
                    cade.telef = cdmReader["telefone"].ToString();                                        
                }               

                cdmReader.Close();
                con.Close();
                return cade; // retorna o cadastro
            }
            public void Cadastrobd(Cadastro cadastro)
            {                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3D2GOF3\SQLEXPRESS; Initial catalog= DB_PIM;" + "Integrated Security = true";
                con.Open();
                SqlCommand cdm = new SqlCommand();
                cdm.Connection = con;
                cdm.CommandText = "INSERT INTO TB_Funcionario " +
                    "(ativo, nome_func, matricula, cpf, cargo, email_func, dtNasc_func, sexo_func, nome_empresa, cnpj_empresa, endereco, numero, cep, bairro, telefone)"
                    +
                "VALUES('" + cadastro.ativo +
                "','" + cadastro.nome +
                "','" + cadastro.matricula +
                "','" + cadastro.cpf +
                "','" + cadastro.cargo +
                "','" + cadastro.email +
                "','" + cadastro.dtnasc +
                "','" + cadastro.sexo +
                "','" + cadastro.nomeempresa +
                "','" + cadastro.cnpj +
                "','" + cadastro.endereco +
                "','" + cadastro.num +
                "','" + cadastro.cep +
                "','" + cadastro.bairro +
                "','" + cadastro.telef + "');";

                cdm.ExecuteNonQuery();
                con.Close();
            }
            public void Excluir(string matricula)
            {                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3D2GOF3\SQLEXPRESS; Initial catalog= DB_PIM;" + "Integrated Security = true";
                con.Open();
                SqlCommand cdm = new SqlCommand();
                cdm.Connection = con;
                cdm.CommandText = " UPDATE TB_Funcionario SET ativo = '0' WHERE Matricula = " + matricula + ";";
                
                cdm.ExecuteNonQuery();
                con.Close();
            }
            public void Alterar(string matricula, string cargo, string telefone, string email)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-3D2GOF3\SQLEXPRESS; Initial catalog= DB_PIM;" + "Integrated Security = true";
                con.Open();
                SqlCommand cdm = new SqlCommand();
                cdm.Connection = con;
                cdm.CommandText = " UPDATE TB_Funcionario SET cargo ='" + cargo + "'," + "telefone = '" + telefone + "'," + "email_func = '" + email + "' WHERE ativo = '1' and Matricula = '" + matricula + "';";
               
                cdm.ExecuteNonQuery();
                con.Close();

            }
        }


    }
}
