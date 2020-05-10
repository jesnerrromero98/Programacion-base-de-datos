using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
    {
     public class accesoDatosEspecialidad
    {
        SqlConnection cnx;
        Especialidad ES= new Especialidad();
        Conexion cn = new Conexion();
        SqlConnection cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List< Especialidad> listaEspecialidad = null;
    }
    public int insertarEspecialidad( Especialidad esp)
    {
       try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegEspecialidad", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue(" @NombreEspecialidad", esp.NombreEspecialidad);
                cm.Parameters.AddWithValue("@DescpEspecialidad ", esp.DescpEspecialidad);
                
                
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
        public List<Especialidad> listarEspecialidad()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegEspecialidad", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue(" @NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");
                

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();

                while (dr.Read())
                {
                    Especialidad esp = new Especialidad();
                   esp.IdEspecialidad = Convert.ToInt32(dr["@IdEspecialidad"].ToString());
                    esp.NombreEspecialidad = dr["@NombreEspecialidad"].ToString();
                    esp.DescpEspecialidad = dr["DescpEspecialidad"].ToString();
                    
                   listaEspecialidad.Add(esp);
                    
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaEspecialidad= null;
               
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaEspecialidad;
        }
        public int eliminarEspecialidad (int IdEspecialidad)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegEspecialidad", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdEspecialidad", @IdEspecialidad);
                cm.Parameters.AddWithValue("@NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");
                

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
        public int EditarEspecialidad (Especialidad es)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegEspecialidad", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdEspecialidad", es.IdEspecialidad);
                cm.Parameters.AddWithValue("@NombreEspecialidad", "");
                cm.Parameters.AddWithValue("@DescpEspecialidad ", "");
                
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
        public List<Especialidad> BuscarEspecialidad(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegEspecialidad", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                cm.Parameters.AddWithValue("@NombreEspecialidad", dato);
                cm.Parameters.AddWithValue("@DescpEspecialidad", "");
                

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaEspecialidad = new List<Especialidad>();
                while (dr.Read())
                {
                   Especialidad esp = new Especialidad();
                    esp.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    esp.NombreEspecialidad = dr["NombreEspecialidad"].ToString();
                    esp.DescpEspecialidad = dr["DescpEspecialidad"].ToString();
                   
                    listaEspecialidad.Add(esp);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                 listaEspecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return  listaEspecialidad;
           }
        }
      
