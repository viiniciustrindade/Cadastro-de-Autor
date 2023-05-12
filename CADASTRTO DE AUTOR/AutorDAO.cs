using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADASTRTO_DE_AUTOR
{
    public class AutorDAO
    {
        private SqlConnection Connection { get; }
        public AutorDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public void Salvar(AutorModel codAutor)
        {
            using (SqlCommand command  = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    //Excluir(codAutor, t);

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibAutor(nomeAutor, descricaoAutor) VALUES(@nome, @descricao)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@nome", codAutor.nomeAutor));
                    command.Parameters.Add(new SqlParameter("@descricao",codAutor.descricao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                        
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void Alterar(AutorModel codAutor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    //Excluir(codAutor, t);

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibAutor SET nomeAutor = @nome, descricaoAutor = @descricao WHERE codAutor = @codAutor");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codAutor", codAutor.codAutor);
                    command.Parameters.Add(new SqlParameter("@nome", codAutor.nomeAutor));
                    command.Parameters.Add(new SqlParameter("@descricao", codAutor.descricao));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }

                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }
        public void Excluir(AutorModel codAutor, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibAutor WHERE codAutor=@codAutor");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codAutor", codAutor.codAutor));
                command.ExecuteNonQuery();
            }  
        }
        public List<AutorModel> GetAutores()
        {
            List<AutorModel> autores = new List<AutorModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT AUT.codAutor, AUT.nomeAutor, AUT.descricaoAutor FROM mvtBibAutor AUT");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        autores.Add(PopulateDr(dr));
                    }
                }
            }
            return autores;
        }
        private AutorModel PopulateDr(SqlDataReader dr)
        {
            string codAutor = "";
            string nomeAutor = "";
            string descricao = "";
            if (DBNull.Value != dr["codAutor"])
            {
                codAutor = dr["codAutor"] + "";
            }
            if (DBNull.Value != dr["nomeAutor"])
            {
                nomeAutor = dr["nomeAutor"] + "";
            } 
            if (DBNull.Value != dr["descricaoAutor"])
            {
                descricao = dr["descricaoAutor"] + "";
            }
            return new AutorModel()
            {
                codAutor = codAutor,
                nomeAutor = nomeAutor,
                descricao = descricao
            };
        }
    }
}
