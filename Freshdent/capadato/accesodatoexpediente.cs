using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaentidades;
using System.Data;


namespace capadato
{
     public class accesodatoexpediente
    {
        SqlConnection cnx;
        expediente exp = new expediente();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<expediente> Listaexpediente = null;

        public int insertarexpediente(expediente exp)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("expedientemedico", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idexpediente", "");
                cm.Parameters.AddWithValue("@idconsulta", exp.idconsulta);
                cm.Parameters.AddWithValue("@codespecialidad", exp.codespecialidad);
                cm.Parameters.AddWithValue("@idreceta", exp.idreceta);
                cm.Parameters.AddWithValue("@idregpaciente", exp.idregpaciente);
                cm.Parameters.AddWithValue("@idcitas", exp.idcitas);

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
        public List<expediente> Listarexpediente()
        {
            try
            {
                cm = new SqlCommand("expedientemedico", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idexpediente", "");
                cm.Parameters.AddWithValue("@idconsulta", "");
                cm.Parameters.AddWithValue("@codespecialidad", "");
                cm.Parameters.AddWithValue("@idreceta", "");
                cm.Parameters.AddWithValue("@idregpaciente", "");
                cm.Parameters.AddWithValue("@idcitas", "");




                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listaexpediente = new List<expediente>();

                while (dr.Read())
                {
                    expediente exp = new expediente();
                    exp.idexpediente = Convert.ToInt32(dr["idexpediente"].ToString());
                    exp.idconsulta = Convert.ToInt32(dr["idconsulta"].ToString());
                    exp.codespecialidad = Convert.ToInt32(dr["codespecialidad"].ToString()); ;
                    exp.idreceta= Convert.ToInt32(dr["idreceta"].ToString());
                    exp.idregpaciente = Convert.ToInt32(dr["idregpaciente"].ToString());
                    exp.idcitas = Convert.ToInt32(dr["idcitas"].ToString());




                    Listaexpediente.Add(exp);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listaexpediente = null;
            }

            finally
            {
                cm.Connection.Close();
            }
            return Listaexpediente;
        }
        public int eliminarexpediente(int idexpediente)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("cita", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idexpediente", idexpediente);
                cm.Parameters.AddWithValue("@idconsulta", "");
                cm.Parameters.AddWithValue("@codespecialidad", "");
                cm.Parameters.AddWithValue("@idreceta", "");
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
        public int editarexpediente(expediente exp)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("paciente", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idexpediente", exp.idexpediente);
                cm.Parameters.AddWithValue("@idconsulta", exp.idconsulta);
                cm.Parameters.AddWithValue("@codespecialidad", exp.codespecialidad);
                cm.Parameters.AddWithValue("@idreceta", exp.idreceta);
                cm.Parameters.AddWithValue("@idregpaciente", exp.idregpaciente);
                cm.Parameters.AddWithValue("@idcitas", exp.idcitas);

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
        public List<expediente> buscarexpediente(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idexpediente",dato);
                cm.Parameters.AddWithValue("@idconsulta", "");
                cm.Parameters.AddWithValue("@codespecialidad", "");
                cm.Parameters.AddWithValue("@idreceta", "");
                cm.Parameters.AddWithValue("@idregpaciente", "");
                cm.Parameters.AddWithValue("@idcitas", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listaexpediente = new List<expediente>();
                while (dr.Read())
                {
                    expediente exp = new expediente();
                    exp.idexpediente = Convert.ToInt32(dr["idexpediente"].ToString());
                    exp.idconsulta = Convert.ToInt32(dr["idconsulta"].ToString());
                    exp.codespecialidad = Convert.ToInt32(dr["codespecialidad"].ToString()); ;
                    exp.idreceta = Convert.ToInt32(dr["idreceta"].ToString());
                    exp.idregpaciente = Convert.ToInt32(dr["idregpaciente"].ToString());
                    exp.idcitas = Convert.ToInt32(dr["idcitas"].ToString());



                    Listaexpediente.Add(exp);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listaexpediente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listaexpediente;
        }
    }
}