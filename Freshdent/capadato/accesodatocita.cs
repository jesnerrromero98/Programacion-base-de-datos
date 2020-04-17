using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaentidades;
using System.Data;

namespace capadato
{
    public class accesodatocita
    {
        SqlConnection cnx;
        cita cit = new cita();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<cita> Listacita = null;

        public int insertarcita(cita cit)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("cita", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcita", "");
                cm.Parameters.AddWithValue("@nuevascitas", cit.nuevacitas);
                cm.Parameters.AddWithValue("@fechacita", cit.fechacita);
                cm.Parameters.AddWithValue("@horadisponible", cit.horadisponible);
                cm.Parameters.AddWithValue("@precio", cit.precio);
                cm.Parameters.AddWithValue("@idregpaciente", cit.idregpaciente);
            

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
        public List<cita> Listarcita()
        {
            try
            {
                cm = new SqlCommand("paciente", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("idcita", "");
                cm.Parameters.AddWithValue("@nuevascitas", "");
                cm.Parameters.AddWithValue("@fechacita", "");
                cm.Parameters.AddWithValue("@horadisponible", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@idregpaciente", "");


                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listacita = new List<cita>();

                while (dr.Read())
                {
                    cita cit = new cita();
                    cit.idcitas = Convert.ToInt32(dr["idcita"].ToString());
                    cit.nuevacitas = Convert.ToDateTime(dr["nuevacita"].ToString());
                    cit.fechacita = Convert.ToDateTime(dr["fechacita"].ToString());
                    cit.horadisponible = Convert.ToDateTime(dr["horadisponible"].ToString());
                    cit.precio = Convert.ToInt32(dr["precio"].ToString());
                    cit.idregpaciente = Convert.ToInt32(dr["idregpaciente"].ToString());


                    Listacita.Add(cit);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listacita = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return Listacita;
        }
        public int eliminarcita(int idcita)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("cita", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idcita", idcita);
                cm.Parameters.AddWithValue("@nuevascitas", "");
                cm.Parameters.AddWithValue("@fechacita", "");
                cm.Parameters.AddWithValue("@horadisponible", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@idregpaciente", "");



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
        public int editarcita(cita cit)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("paciente", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcita", cit.idcitas);
                cm.Parameters.AddWithValue("@nuevascitas", cit.nuevacitas);
                cm.Parameters.AddWithValue("@fechacita", cit.fechacita);
                cm.Parameters.AddWithValue("@horadisponible", cit.horadisponible);
                cm.Parameters.AddWithValue("@precio", cit.precio);
                cm.Parameters.AddWithValue("@idregpaciente", cit.idregpaciente);


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
        public List<cita> buscarcita(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("idcita", dato);
                cm.Parameters.AddWithValue("@nuevascitas", "");
                cm.Parameters.AddWithValue("@fechacita", "");
                cm.Parameters.AddWithValue("@horadisponible", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@idregpaciente", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listacita = new List<cita>();
                while (dr.Read())
                {
                    cita cit = new cita();
                    cit.idcitas = Convert.ToInt32(dr["idcita"].ToString());
                    cit.nuevacitas = Convert.ToDateTime(dr["nuevacita"].ToString());
                    cit.fechacita = Convert.ToDateTime(dr["fechacita"].ToString());
                    cit.horadisponible = Convert.ToDateTime(dr["horadisponible"].ToString());
                    cit.precio = Convert.ToInt32(dr["precio"].ToString());
                    cit.idregpaciente = Convert.ToInt32(dr["idregpaciente"].ToString());

                
                    Listacita.Add(cit);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listacita = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listacita;
        }
    }
}
  
