using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_de_sala.DAL
{
    public class ConexaoBD
    {
        static SqlConnection _conexao;

        public static SqlConnection getConexao()
        {
            if (_conexao == null)
            {
                _conexao = new SqlConnection(@"Server=.\SENAI2022; Database=BDGestaoSala; User id =sa; Password=senai.123;");
            }

            return _conexao;
        }


    }
}
