using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class accesoDatosRecetaMedica
    {
        SqlConnection cnx;
        RecetaMedica R = new  RecetaMedica();
        Conexion cn = new Conexion();
        SqlConnection cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List< RecetaMedica> listaRecetaMedica = null;
    }
    public int insertarRecetaMedica(RecetaMedica R)
    {
       try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegRecetaMdica", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@NombreMedicamento", R.NombreMedicamento);
                cm.Parameters.AddWithValue("@Cantidad", R.Cantidad);
                cm.Parameters.AddWithValue("@Indicaciones", R.Indicaciones);
               
                
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
        public List<RecetaMedica> listaRecetaMedica()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegRecetaMdica", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@NombreMedicamento", R.NombreMedicamento);
                cm.Parameters.AddWithValue("@Cantidad", R.Cantidad);
                cm.Parameters.AddWithValue("@Indicaciones", R.Indicaciones);
                

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaRecetaMedica = new List<RecetaMedica>();

                while (dr.Read())
                {
                    RecetaMedica R= new RecetaMedica();
                    R.IdReceta = Convert.ToInt32(dr["IdReceta"].ToString());
                    R.NombreMedicamento = dr["NombreMedicamento"].ToString();
                    R.Cantidad = dr["Cantidad"].ToString();
                    R.Indicaciones = dr["Indicaciones"].ToString();
                    
                    
                    listaRecetaMedica.Add(R);
                    
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
               listaRecetaMedica= null;
               
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaRecetaMedica;
        }
        public int eliminarRecetaMedica(int IdReceta)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegRecetaMdica", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdReceta", R.IdReceta);
                cm.Parameters.AddWithValue("@NombreMedicamento", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Indicaciones", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = - 1;

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
        public int EditarRecetaMedica (RecetaMedica R)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegRecetaMdica", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdReceta",  R.IdReceta);
                cm.Parameters.AddWithValue("@NombreMedicamento", "");
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Indicaciones", "");
                

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
        public List<RecetaMedica> BuscarRecetaMedica(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                
                 cm = new SqlCommand("RegRecetaMdica", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@NombreMedicamento", R.NombreMedicamento);
                cm.Parameters.AddWithValue("@Cantidad", "");
                cm.Parameters.AddWithValue("@Indicaciones", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
               listaRecetaMedica = new List<RecetaMedica>();
                while (dr.Read())
                {
                  RecetaMedica R= new RecetaMedica();
                    R.IdReceta = Convert.ToInt32(dr["IdReceta"].ToString());
                    R.NombreMedicamento = dr["NombreMedicamento"].ToString();
                    R.Cantidad = dr["Cantidad"].ToString();
                    R.Indicaciones = dr["Indicaciones"].ToString();
                   listaRecetaMedica.Add(R);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaRecetaMedica = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return  listaRecetaMedica;
           }
        }
    
