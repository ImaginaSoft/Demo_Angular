using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoAngular.Model
{
    public class FichaPropuestaDataAccesLayer
    {

        string connectionString = "Data Source=192.168.50.60;initial catalog =BDTURISMO;User ID=dbadmin;Password=123abc";


        public IEnumerable<FichaPropuesta> ObtenerListadoPropuesta()
        {
            try
            {
                List<FichaPropuesta> lstfpropuesta = new List<FichaPropuesta>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    //SqlCommand cmd = new SqlCommand("VTA_PropuestaServicio_S_GG", con);
                    SqlCommand cmd = new SqlCommand("VTA_PropuestaNroPedido_S_GG", con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@NroPedido", SqlDbType.Int).Value = 147140;
                    //cmd.Parameters.Add("@NroPropuesta", SqlDbType.Int).Value = 6;

                    //cmd.Parameters.AddWithValue("@NroPedido", 162436);
                    //cmd.Parameters.AddWithValue("@NroPropuesta", 8);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        FichaPropuesta fpropuesta = new FichaPropuesta
                        {
                            NroPedido = Convert.ToInt32(rdr["NroPedido"]),
                            NroPropuesta = Convert.ToInt32(rdr["NroPropuesta"]),
                            DesPropuesta = rdr["DesPropuesta"].ToString()
                            //NroDia = Convert.ToInt32(rdr["NroDia"]),
                            //7NroOrden = Convert.ToInt32(rdr["NroOrden"]),
                            //NroServicio = Convert.ToInt32(rdr["NroServicio"]),
                            //DesServicio = rdr["DesServicio"].ToString(),
                            //DesServicioDet = rdr["DesServicioDet"].ToString()
                        };

                        lstfpropuesta.Add(item: fpropuesta);
                    }

                    con.Close();
                }

                return lstfpropuesta;

            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public IEnumerable<FichaPropuesta> ObtenerDetallePropuesta(int nroPedido,int nroPropuesta)
        {
            try
            {
                List<FichaPropuesta> lstpropuestadet = new List<FichaPropuesta>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    SqlCommand cmd = new SqlCommand("VTA_PropuestaServicio_S_GG", con);
                    //SqlCommand cmd = new SqlCommand("VTA_PropuestaNroPedido_S", con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@NroPedido", SqlDbType.Int).Value = nroPedido;
                    cmd.Parameters.Add("@NroPropuesta", SqlDbType.Int).Value = nroPropuesta;

                    //cmd.Parameters.AddWithValue("@NroPedido", 162436);
                    //cmd.Parameters.AddWithValue("@NroPropuesta", 8);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        FichaPropuesta fpropuesta = new FichaPropuesta
                        {
                                NroPedido = Convert.ToInt32(rdr["NroPedido"]),
                                //NroPropuesta = Convert.ToInt32(rdr["NroPropuesta"]),
                                //DesPropuesta = rdr["DesPropuesta"].ToString()
                                NroDia = Convert.ToInt32(rdr["NroDia"]),
                                NroOrden = Convert.ToInt32(rdr["NroOrden"]),
                                NroServicio = Convert.ToInt32(rdr["NroServicio"]),
                                DesServicio = rdr["DesServicio"].ToString(),
                                DesServicioDet = rdr["DesServicioDet"].ToString()

                        };

                    lstpropuestadet.Add(item: fpropuesta);
                    }

                    con.Close();
                }

                return lstpropuestadet;

            }
            catch (Exception ex)
            {
                throw;
            }
        }






    }
}
