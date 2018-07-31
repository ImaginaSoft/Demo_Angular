using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoAngular.Model
{
    public class PedidoDataAccessLayer
    {
        string connectionString = "Data Source=192.168.50.60;initial catalog =BDTURISMO;User ID=dbadmin;Password=123abc";

        public IEnumerable<Pedido> ObtenerListadoPedido()
        {
            try
            {
                List<Pedido> lstpedido = new List<Pedido>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM CPEDIDO WHERE CodVendedor='MAYRA' AND FchPedido > = '2018-06-15';", con);

                    //cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Pedido pedido = new Pedido
                        {
                            NroPedido = Convert.ToInt32(rdr["NroPedido"]),
                            DesPedido = rdr["DesPedido"].ToString()
                        };

                        lstpedido.Add(item: pedido);
                    }
                    con.Close();
                }
                return lstpedido;
            }
            catch
            {
                throw;
            }
        }

        private string GetValue(IDataReader registo,
                           string columna)
        {
            var lvalue = registo[columna];

            return (((lvalue is DBNull) || (lvalue == null)) ? null : registo[columna].ToString());
        }

    }
}
