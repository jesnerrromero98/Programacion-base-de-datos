using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using capaentidades;
using System.Data;

namespace capadato
{
    public class accesodatoregpaciente
    {
        SqlConnection cnx;
        registropaciente reg = new registropaciente();
        conexion cn = new conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<registropaciente> Listapaciente = null;

        public int insertarpaciente(registropaciente reg)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("registro_pacientes", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombrepac", reg.nombrepac);
                cm.Parameters.AddWithValue("@apeidopac", reg.apeidopac);
                cm.Parameters.AddWithValue("@direccion", reg.direccion);
                cm.Parameters.AddWithValue("@departamento", reg.departamento);
                cm.Parameters.AddWithValue("@municipio", reg.municipio);
                cm.Parameters.AddWithValue("@celular", reg.celular);
                cm.Parameters.AddWithValue("@telefono", reg.telefono);
                cm.Parameters.AddWithValue("@edad", reg.edad);
                cm.Parameters.AddWithValue("@cedula", reg.cedula);

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

        public List<registropaciente> Listarpaciente()
        {
            try
            {
                cm = new SqlCommand("registro_pacientes", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("idregpaciente", "");
                cm.Parameters.AddWithValue("@nombrepac", "");
                cm.Parameters.AddWithValue("@apeidopac", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@departamento", "");
                cm.Parameters.AddWithValue("@municipio", "");
                cm.Parameters.AddWithValue("@celular", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@edad", "");
                cm.Parameters.AddWithValue("@cedula", "");
                
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listapaciente = new List<registropaciente>();

                while (dr.Read())
                {
                    registropaciente cue = new registropaciente();
                    reg.idregpaciente = Convert.ToInt32(dr["idcuenta"].ToString());
                    reg.nombrepac = dr["nombrepac"].ToString();
                    reg.apeidopac = dr["apeidopac"].ToString();
                    reg.direccion = dr["direccion"].ToString();
                    reg.departamento = dr["departamento"].ToString();
                    reg.municipio = dr["municipio"].ToString();
                    reg.celular= Convert.ToInt32(dr["celular".ToString()]);
                    reg.telefono = Convert.ToInt32(dr["relefono".ToString()]);
                    reg.edad = Convert.ToInt32(dr["edad".ToString()]); 
                    reg.cedula = dr["cedula"].ToString();

                    Listapaciente.Add(cue);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listapaciente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listapaciente;
        }
        public int eliminarpaciente(int idregpaciente)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("registro_pacientes", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("idregpaciente", idregpaciente);
                cm.Parameters.AddWithValue("@nombrepac", "");
                cm.Parameters.AddWithValue("@apeidopac", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@departamento", "");
                cm.Parameters.AddWithValue("@municipio", "");
                cm.Parameters.AddWithValue("@celular", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@edad", "");
                cm.Parameters.AddWithValue("@cedula", "");
                
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

        public int editarpaciente(registropaciente reg)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("registro_pacientes", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("idregpaciente", reg.idregpaciente);
                cm.Parameters.AddWithValue("@nombrepac", "");
                cm.Parameters.AddWithValue("@apeidopac", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@departamento", "");
                cm.Parameters.AddWithValue("@municipio", "");
                cm.Parameters.AddWithValue("@celular", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@edad", "");
                cm.Parameters.AddWithValue("@cedula", reg.cedula);
                
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

        public List<registropaciente> buscarpaciente(string dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("registro_paciente", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("idregpaciente", "");
                cm.Parameters.AddWithValue("@nombrepac", dato);
                cm.Parameters.AddWithValue("@apeidopac", "");
                cm.Parameters.AddWithValue("@direccion", "");
                cm.Parameters.AddWithValue("@departamento", "");
                cm.Parameters.AddWithValue("@municipio", "");
                cm.Parameters.AddWithValue("@celular", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@edad", "");
                cm.Parameters.AddWithValue("@cedula", dato);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                Listapaciente= new List<registropaciente>();

                while (dr.Read())
                {
                    registropaciente reg = new registropaciente();
                    reg.idregpaciente = Convert.ToInt32(dr["idcuenta"].ToString());
                    reg.nombrepac = dr["nombrepac"].ToString();
                    reg.apeidopac = dr["apeidopac"].ToString();
                    reg.direccion = dr["direccion"].ToString();
                    reg.departamento = dr["departamento"].ToString();
                    reg.municipio = dr["municipio"].ToString();
                    reg.celular = Convert.ToInt32(dr["celular".ToString()]);
                    reg.telefono = Convert.ToInt32(dr["relefono".ToString()]);
                    reg.edad = Convert.ToInt32(dr["edad".ToString()]);
                    reg.cedula = dr["cedula"].ToString();

                    Listapaciente.Add(reg);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                Listapaciente = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return Listapaciente;
        }
    }
}