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

                var lstPedido = new List<Pedido>();

                using (SqlConnection objConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand objCommand = new SqlCommand())
                    {

                        objCommand.CommandText = "SELECT * FROM CPEDIDO WHERE CodVendedor='MAYRA' AND FchPedido > = '2018-06-15';";
                        objCommand.CommandType = CommandType.Text;
                        objCommand.Connection = objConnection;
                        objConnection.Open();

                        using (var reader = objCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                var pedido = new Pedido
                                {
                                    NroPedido = int.Parse(GetValue(reader, "NroPedido")),
                                    DesPedido = GetValue(reader, "DesPedido"),
                                    FchPedido = DateTime.Parse(GetValue(reader, "FchPedido"))



                                };
                                //pedido.CodVendedor = Convert.ToChar(GetValue(reader, "CodVendedor"));

                                lstPedido.Add(pedido);

                            }

                            objConnection.Close();

                        }

                    }

                    return lstPedido;

                }

            }
            catch {
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
