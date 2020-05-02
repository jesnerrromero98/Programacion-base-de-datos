using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaentidades;
using System.Data;


namespace capadato
{
    public class accesodatoespecialidad
    {
        SqlConnection cnx;
        especialidad esp = new especialidad();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<especialidad> Listaespecialidad = null;

        public int insertarespecialidad(especialidad esp)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("especialidades", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@codespecialidad", "");
                cm.Parameters.AddWithValue("@nombrespecialidad", esp.nombrespecialidad);
                cm.Parameters.AddWithValue("@descespecialidad", esp.descespecialidad);
                cm.Parameters.AddWithValue("@idcita", esp.idcita);
               
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

        public List<especialidad> Listarespecialidad()
        {
            try
            {
                cm = new SqlCommand("especialidades", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("codespecialidad", "");
                cm.Parameters.AddWithValue("@nombrespecialidad", "");
                cm.Parameters.AddWithValue("@descespecialidad", "");
                cm.Parameters.AddWithValue("@idcita", "");
              
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listaespecialidad = new List<especialidad>();

                while (dr.Read())
                {
                    especialidad esp = new especialidad();
                    esp.codespecialidad = Convert.ToInt32(dr["codespecialidad"].ToString());
                    esp.nombrespecialidad = dr["nombrespecialidad"].ToString();
                    esp.descespecialidad = dr["descespecialidad"].ToString();
                    esp.idcita= Convert.ToInt32(dr["idcita"].ToString());
                    
                    Listaespecialidad.Add(esp);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listaespecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listaespecialidad;
        }

        public int eliminarespecialidad(int codespecialidad)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("especialidades", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("codespecialidad", codespecialidad);
                cm.Parameters.AddWithValue("@nombrespecialidad", "");
                cm.Parameters.AddWithValue("@descespecialidad", "");
                cm.Parameters.AddWithValue("@idcita", "");
                
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
        public int editarespecialidad(especialidad esp)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("especialidades", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@codespecialidad", esp.codespecialidad);
                cm.Parameters.AddWithValue("@nombrespecialidad", "");
                cm.Parameters.AddWithValue("@descespecialidad", "");
                cm.Parameters.AddWithValue("@idcita", esp.idcita);
                
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
        public List<especialidad> buscarespecialidad(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("especialidades", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("codespecialidad", "");
                cm.Parameters.AddWithValue("@nombrespecialidad", dato);
                cm.Parameters.AddWithValue("@descespecialidad", "");
                cm.Parameters.AddWithValue("@idcita", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listaespecialidad = new List<especialidad>();
                while (dr.Read())
                {
                    especialidad esp = new especialidad();
                    esp.codespecialidad = Convert.ToInt32(dr["codespecialidad"].ToString());
                    esp.nombrespecialidad = Convert.ToString(dr["nombrespecialidad"].ToString());
                    esp.descespecialidad = Convert.ToString(dr["descespecialidad"].ToString());
                    esp.idcita = Convert.ToInt32(dr["idcita"].ToString());
                    
                    Listaespecialidad.Add(esp);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listaespecialidad = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listaespecialidad;
        }
    }
}