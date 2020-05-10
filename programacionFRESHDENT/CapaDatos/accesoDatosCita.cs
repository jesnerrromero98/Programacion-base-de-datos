using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
     public class accesoDatosCita
    {
        SqlConnection cnx;
        Cita Ci = new  Cita();
        Conexion cn = new Conexion();
        SqlConnection cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Cita> listacita = null;
    }

     public int insertarCita(Cita Ci)
    {
       try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegCita", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@NuevaCita", Ci.NuevaCita);
                cm.Parameters.AddWithValue("@FechaCita", Ci.FechaCita);
                cm.Parameters.AddWithValue("@HoraDisponible", Ci.HoraDisponible);
                cm.Parameters.AddWithValue("@Precio", Ci.Precio);
                cm.Parameters.AddWithValue("@Idexpediente", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
               
                
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
        public List<Cita> listaCita()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegCita", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@NuevaCita", Ci.NuevaCita);
                cm.Parameters.AddWithValue("@FechaCita", Ci.FechaCita);
                cm.Parameters.AddWithValue("@HoraDisponible", Ci.HoraDisponible);
                cm.Parameters.AddWithValue("@Precio", Ci.Precio);
                cm.Parameters.AddWithValue("@Idexpediente", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaCita = new List<Cita>();

                while (dr.Read())
                {
                    Cita Ci= new Cita();
                    Ci.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    Ci.NuevaCita = dr["NuevaCita"].ToString();
                    Ci.FechaCita = dr["FechaCita"].ToString();
                    Ci.HoraDisponible = dr["HoraDisponible"].ToString();
                    Ci.Precio = dr["Precio"].ToString();
                    Ci.Idexpediente = Convert.ToInt32(dr["Idexpediente"].ToString());
                    Ci.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    
                    
                    listaCita.Add(Ci);
                    
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
               listaCita= null;
               
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaCita;
        }
        public int eliminarCita(int IdCita)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegCita", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdCita", Ci.IdCita);
                cm.Parameters.AddWithValue("@NuevaCita", "");
                cm.Parameters.AddWithValue("@FechaCita", "");
                cm.Parameters.AddWithValue("@HoraDisponible", "");
                cm.Parameters.AddWithValue("@Precio", "");
                cm.Parameters.AddWithValue("@Idexpediente", Ci.Idexpediente);
                cm.Parameters.AddWithValue("@IdEspecialidad ", Ci.IdEspecialidad );


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
        public int EditarCita (Cita Ci)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegCita", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdCita",  Ci.IdCita);
                cm.Parameters.AddWithValue("@NuevaCita", "");
                cm.Parameters.AddWithValue("@FechaCita", "");
                cm.Parameters.AddWithValue("@HoraDisponible", "");
                cm.Parameters.AddWithValue("@precio", "");
                cm.Parameters.AddWithValue("@Idexpediente", Ci.Idexpediente);
                cm.Parameters.AddWithValue("@IdEspecialidad ", Ci.IdEspecialidad );
                

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
        public List<Cita> BuscarCita(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                
                 cm = new SqlCommand("RegCita", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@NuevaCita", Ci.NuevaCita);
                cm.Parameters.AddWithValue("@FechaCita", Ci.FechaCita);
                cm.Parameters.AddWithValue("@HoraDisponible", Ci.HoraDisponible);
                cm.Parameters.AddWithValue("@Precio", Ci.Precio);
                cm.Parameters.AddWithValue("@Idexpediente", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
               listaCita = new List<Cita>();
                while (dr.Read())
                {
                  Cita R= new Cita();
                    Ci.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    Ci.NuevaCita = dr["NuevaCita"].ToString();
                    Ci.FechaCita= dr["FechaCita"].ToString();
                    Ci.HoraDisponible = dr["HoraDisponible"].ToString();
                    Ci.Precio = dr["Precio"].ToString();
                    Ci.Idexpediente = Convert.ToInt32(dr["Idexpediente"].ToString());
                    Ci.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                   listaCita.Add(R);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaCita = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return  listaCita;
           }
        }

