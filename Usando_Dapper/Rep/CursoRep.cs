using Dapper;
using System;
using System.Linq;
using System.Data.SqlClient;
using Usando_Dapper.Fabrica;

namespace Usando_Dapper.Rep
{
    public class CursoRep
    {
        public Curso Obter(Guid parametro)
        {
            Curso curso = null;            

            DapperOperacoes operacao = new DapperOperacoes(Conexao.Obter);
            object param = new  { Id = parametro };
            curso = operacao.Query<Curso>("SELECT * FROM CURSO WHERE Id = @Id ", param);

            return curso;
        }

    }
}
