using Dapper;
using Gestao_de_sala.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_de_sala.DAL
{
    public class OcupacaoDAO
    {
        SqlConnection _conexao;
        public OcupacaoDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Ocupacao> getTodaAsOcupacoes()
        {
            string query = "select * from ocupacao";
            _conexao.Open();

            var lista = (List<Ocupacao>)_conexao.Query(query);

            return lista;
        }
    }
}
