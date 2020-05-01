using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaentidades;
using System.Data;


namespace capadato
{
    public class accesodatoconsulta
    {

        SqlConnection cnx;
        consulta con = new consulta();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<consulta> Listaconsulta = null;

        public int insertarconsulta(consulta con)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("consulta", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idconsulta", "");
                cm.Parameters.AddWithValue("@tipoconsulta", con.tipoconsulta);
                cm.Parameters.AddWithValue("@idregpaciente", con.idregpaciente);
                cm.Parameters.AddWithValue("@idcitas", con.idcitas);
       

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;

        }
        public List<consulta> Listarconsulta()
        {
            try
            {
                cm = new SqlCommand("paciente", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idconsulta", "");
                cm.Parameters.AddWithValue("@tipoconsulta", "");
                cm.Parameters.AddWithValue("@idregpaciente", "");
                cm.Parameters.AddWithValue("@idcitas", "" );




                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listaconsulta = new List<consulta>();

                while (dr.Read())
                {
                    consulta con = new consulta();
                    con.idcitas = Convert.ToInt32(dr["idconsulta"].ToString());
                    con.tipoconsulta = Convert.ToString(dr["tipoconsulta"].ToString());
                    con.idregpaciente= Convert.ToInt32(dr["idregpaciente"].ToString()); ;
                    con.idcitas = Convert.ToInt32(dr["idcita"].ToString());




                    Listaconsulta.Add(con);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listaconsulta = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return Listaconsulta;
        }
        public int eliminarconsulta(int idconsulta)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("cita", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idconsulta", idconsulta);
                cm.Parameters.AddWithValue("@tipoconsulta", "");
                cm.Parameters.AddWithValue("@idregpaciente", "");
                cm.Parameters.AddWithValue("@idcitas", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
        public int editarconsulTa(consulta con)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("paciente", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idconsulta", con.idconsulta);
                cm.Parameters.AddWithValue("@tipoconsulta", con.tipoconsulta);
                cm.Parameters.AddWithValue("@idregpaciente", con.idregpaciente);
                cm.Parameters.AddWithValue("@idcitas", con.idcitas);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
        public List<consulta> buscarconsulta(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idconsulta",dato);
                cm.Parameters.AddWithValue("@tipoconsulta", "");
                cm.Parameters.AddWithValue("@idregpaciente","");
                cm.Parameters.AddWithValue("@idcitas", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listaconsulta = new List<consulta>();
                while (dr.Read())
                {
                    consulta con = new consulta();
                    con.idcitas = Convert.ToInt32(dr["idconsulta"].ToString());
                    con.tipoconsulta = Convert.ToString(dr["tipoconsulta"].ToString());
                    con.idregpaciente = Convert.ToInt32(dr["idregpaciente"].ToString()); ;
                    con.idcitas = Convert.ToInt32(dr["idcita"].ToString());



                    Listaconsulta.Add(con);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listaconsulta= null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listaconsulta;
        }
    }
}