using System.Configuration;

namespace Usando_Dapper.Fabrica
{
    public static class Conexao
    {
        public static string Obter
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ObjetivoProvaHomologacao"].ConnectionString;
            }
        }
    }
}
