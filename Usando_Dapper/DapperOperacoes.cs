using System.Linq;
using Dapper;
using System.Data.SqlClient;
using System;

namespace Usando_Dapper
{
    public  class DapperOperacoes
    {
        public DapperOperacoes(string conexao)
        {
            this._strConexao = conexao;
            this.Parametors = new object[] { };
        }

        private readonly string _strConexao = null;
        public object[] Parametors { get; set; }

        public  T Query<T>(string sql, object param)
        {
            T resultado;

            using (var conexao = new SqlConnection(_strConexao))
            {
                resultado = conexao.Query<T>(sql, param).FirstOrDefault();
            }
            this.CLear();
            return resultado;
        }

        private void CLear()
        {
            if(this.Parametors.Count() > 0)
                Array.Clear(this.Parametors, 0, this.Parametors.Length);
        }
    }
}
