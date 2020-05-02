using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaentidades;
using System.Data;


namespace capadato
{
    public class accesodatorecetamedica
    {
        SqlConnection cnx;
        recetamedica rec= new recetamedica();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<recetamedica> Listarecetamedica = null;

        public int insertarrecetamedica(recetamedica rec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("reseta", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idreceta", "");
                cm.Parameters.AddWithValue("@nombremedicamento", rec.nombremedicamento);
                cm.Parameters.AddWithValue("@cantidad", rec.cantidad);
                cm.Parameters.AddWithValue("@indicaciones", rec.indicaciones);
                cm.Parameters.AddWithValue("@idregpaciente", rec.idregpaciente);
                
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

        public List<recetamedica> Listarrecetamedica()
        {
            try
            {
                cm = new SqlCommand("reseta", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idreceta", "");
                cm.Parameters.AddWithValue("@nombremedicamento", "");
                cm.Parameters.AddWithValue("@cantidad", "");
                cm.Parameters.AddWithValue("@indicaciones", "");
                cm.Parameters.AddWithValue("@idregpaciente", "");
                
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listarecetamedica = new List<recetamedica>();

                while (dr.Read())
                {
                   recetamedica rec = new recetamedica();
                    rec.idreceta= Convert.ToInt32(dr["idreceta"].ToString());
                    rec.nombremedicamento = Convert.ToString(dr["nombremedicamento"].ToString());
                    rec.cantidad = Convert.ToInt32(dr["cantidad"].ToString()); ;
                    rec.indicaciones= Convert.ToString(dr["indicaciones "].ToString());
                    rec.idregpaciente = Convert.ToInt32(dr["idregpaciente"].ToString());
                    
                    Listarecetamedica.Add(rec);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listarecetamedica = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listarecetamedica;
        }

        public int eliminarrecetamedica(int idreceta)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("reseta", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idreceta", idreceta);
                cm.Parameters.AddWithValue("@nombremedicamento", "");
                cm.Parameters.AddWithValue("@cantidad", "");
                cm.Parameters.AddWithValue("@indicaciones", "");
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

        public int editarrecetamedica(recetamedica rec)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("reseta", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idreceta",rec.idreceta);
                cm.Parameters.AddWithValue("@nombremedicamento", rec.nombremedicamento);
                cm.Parameters.AddWithValue("@cantidad","");
                cm.Parameters.AddWithValue("@indicaciones","");
                cm.Parameters.AddWithValue("@idregpaciente", rec.idregpaciente);

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

        public List<recetamedica> buscarrecetamedica(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("reseta", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idreceta", "");
                cm.Parameters.AddWithValue("@nombremedicamento", dato);
                cm.Parameters.AddWithValue("@cantidad", "");
                cm.Parameters.AddWithValue("@indicaciones",dato);
                cm.Parameters.AddWithValue("@idregpaciente", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listarecetamedica = new List<recetamedica>();

                while (dr.Read())
                {
                    consulta con = new consulta();
                    rec.idreceta = Convert.ToInt32(dr["idreceta"].ToString());
                    rec.nombremedicamento = Convert.ToString(dr["nombremedicamento"].ToString());
                    rec.cantidad = Convert.ToInt32(dr["cantidad"].ToString()); ;
                    rec.indicaciones = Convert.ToString(dr["indicaciones "].ToString());
                    rec.idregpaciente = Convert.ToInt32(dr["idregpaciente"].ToString());
                    
                    Listarecetamedica.Add(rec);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listarecetamedica = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listarecetamedica;
        }
    }
}