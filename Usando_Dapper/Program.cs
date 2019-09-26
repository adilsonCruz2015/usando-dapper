using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usando_Dapper.Rep;

namespace Usando_Dapper
{
    class Program
    {
        static string strConexao = ConfigurationManager.ConnectionStrings["ObjetivoProvaHomologacao"].ConnectionString;

        static void Main(string[] args)
        {
            
            var curso = new CursoRep();
            curso.Obter(Guid.Parse("DB09CA58-3223-446F-B52B-7B694E9D3843"));


            Console.ReadLine();
        }


        public static void Execute()
        {
            using (var conexaoBD = new SqlConnection(strConexao))
            {
                IEnumerable<Unidade> unidades = conexaoBD.Query<Unidade>("Select * from Unidade");

                Console.WriteLine("{0} - {1} - {2} ", "Nome", "Referencia", "Descricao");

                foreach(Unidade unidade in unidades)
                    Console.WriteLine("{0} - {1} - {2}", unidade.Nome, unidade.Referencia, unidade.Descricao);

            }
        }
    }
}
