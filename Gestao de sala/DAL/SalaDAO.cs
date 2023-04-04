using Dapper;
using Gestao_de_sala.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_de_sala.DAL
{
    public class SalaDAO
    {
        SqlConnection _conexao;
        public SalaDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Sala> getTodaAsSalas()
        {
            string query = "select * from sala";
            _conexao.Open();

            var lista = (List<Sala>)_conexao.Query(query);

            return lista;
        }

    }
}
