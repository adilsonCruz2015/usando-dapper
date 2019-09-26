

using System;

namespace Usando_Dapper
{
    public class Curso
    {
        public Guid Id { get; protected set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Sigla { get; set; }

        public string Status { get; set; }

        public DateTime CriadoEm { get; protected set; }

        public DateTime AlteradoEm { get; protected set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
