using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class accesoDatosExpediente
    {
        SqlConnection cnx;
        Expediente E = new Expediente();
        Conexion cn = new Conexion();
        SqlConnection cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Expediente> listaExpedientes = null;
    }
    public int insertarExpediente(Expediente ex)
    {
       try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegPaciente", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@Idexpediente", "");
                cm.Parameters.AddWithValue("@Nombre", ex.Nombre);
                cm.Parameters.AddWithValue("@Apellido", ex.Apellido);
                cm.Parameters.AddWithValue("@Departamento", ex.Departamento);
                cm.Parameters.AddWithValue("@Municipio", ex.Municipio);
                cm.Parameters.AddWithValue("@Celular", ex.Celular);
                cm.Parameters.AddWithValue("@FechaNacimiento", ex.FechaNacimiento);
                cm.Parameters.AddWithValue("@cedula", ex.Cedula);
                
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
        public List<Expediente> listarExpedientes()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegPaciente", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@Idexpediente", "");
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Apellido", "");
                cm.Parameters.AddWithValue("@Departamento", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Celular", "");
                cm.Parameters.AddWithValue("@FechaNacimiento", "");
                cm.Parameters.AddWithValue("@Celular", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpedientes = new List<Expediente>();

                while (dr.Read())
                {
                    Expediente exp = new Expediente();
                    exp.Idexpediente = Convert.ToInt32(dr["Idexpediente"].ToString());
                    exp.Nombre = dr["Nombre"].ToString();
                    exp.Apellido = dr["Apellido"].ToString();
                    exp.Departamento = dr["Departamento"].ToString();
                    exp.Municipio = dr["Municipio"].ToString();
                    exp.Celular = Convert.ToInt32(dr["Celular"].ToString());
                    exp.FechaNacimiento = Convert.ToInt32(dr["FechaNacimiento"].ToString());
                    exp.Cedula = dr["Cedula"].ToString();
                    
                    listaExpedientes.Add(exp);
                    
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaExpedientes= null;
               
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaExpedientes;
        }
        public int eliminarExpediente (int Idexpediente)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegPaciente", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@Idexpediente", Idexpediente);
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Apellido", "");
                cm.Parameters.AddWithValue("@Departamento", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Celular", "");
                cm.Parameters.AddWithValue("@FechaNacimiento", "");
                cm.Parameters.AddWithValue("@Cedula", "");

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
        public int EditarExpediente (Expediente ex)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegPaciente", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@Idexpediente", ex.Idexpediente);
                cm.Parameters.AddWithValue("@Nombre", "");
                cm.Parameters.AddWithValue("@Apellido", "");
                cm.Parameters.AddWithValue("@Departamento", "");
                cm.Parameters.AddWithValue("@Municipio", "");
                cm.Parameters.AddWithValue("@Celular", "");
                cm.Parameters.AddWithValue(" @FechaNacimiento", "");
                cm.Parameters.AddWithValue("@Cedula", "");

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
        public List<Expediente> BuscarExpediente(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegPaciente", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@Idexpediente", "");
                cm.Parameters.AddWithValue("@Nombre", dato);
                cm.Parameters.AddWithValue("@Apellido", "");
                cm.Parameters.AddWithValue("@Departamento", "");
                cm.Parameters.AddWithValue("@Municipio","");
                cm.Parameters.AddWithValue("@Celular", "");
                cm.Parameters.AddWithValue("@FechaNacimiento", "");
                cm.Parameters.AddWithValue(" @Cedula", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaExpedientes = new List<Expediente>();
                while (dr.Read())
                {
                   Expediente exp = new Expediente();
                    exp.Idexpediente = Convert.ToInt32(dr["Idexpediente"].ToString());
                    exp.Nombre = dr["Nombre"].ToString();
                    exp.Apellido = dr["Apellido"].ToString();
                    exp.Departamento = dr["Departamento"].ToString();
                    exp.Municipio = dr["Municipio"].ToString();
                    exp.Celular = Convert.ToInt32(dr["Celular"].ToString());
                    exp.FechaNacimiento = Convert.ToInt32(dr["FechaNacimiento"].ToString());
                    exp.Cedula = dr["Cedula"].ToString();
                    listaExpedientes.Add(exp);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaExpedientes = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaExpedientes;
           }
        }

    


