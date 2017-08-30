using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaControlHorario.Entidades;

namespace SistemaControlHorario.Datos
{
    public class Consultas
    {

        //LABORATORIO
        public static void InsLaboratorio(Laboratorio Objeto)
        {
            try
            {
                AccesoDatos.reaOperacion("Insert Into Laboratorio ( Codigo, Nombre,Capacidad,Ubicacion,Imagen,IdDoc) values('" + Objeto.Codigo + "','" + Objeto.Nombre + "','" + Objeto.Capacidad + "','" + Objeto.Ubicacion + "','" + Objeto.Imagen + "','" + Objeto.JefeLaboratorio + "')");
            }
            catch { }

            try
            {
                AccesoDatos.reaOperacion("Update Personal set CondJefe='SI' from Personal where IdDoc='" + Objeto.JefeLaboratorio + "'");
            }
            catch { }

        }
        public static void ModLaboratorio(Laboratorio Objeto)
        {
            try
            {
                AccesoDatos.reaOperacion("Update Laboratorio set Codigo='" + Objeto.Codigo + "',Nombre='" + Objeto.Nombre + "', Capacidad='" + Objeto.Capacidad + "',Ubicacion='" + Objeto.Ubicacion + "' ,Imagen='" + Objeto.Ubicacion + "',IdDoc='" + Objeto.JefeLaboratorio + "' from Laboratorio where IdLaboratorio='" + Objeto.IdLaboratorio + "'");
            }
            catch { }

            AccesoDatos.reaOperacion("Update Personal set CondJefe='SI' from Personal where IdDoc='" + Objeto.JefeLaboratorio + "'");


        }
        public static List<Laboratorio> listaLaboratorio()
        {

            List<Laboratorio> lista = new List<Laboratorio>();
            DataTable tablaDato = new DataTable();

            tablaDato = AccesoDatos.reaConsulVista("SELECT dbo.Personal.Nombre AS JefeLaboratorio, dbo.Laboratorio.IdLaboratorio, dbo.Laboratorio.Codigo, dbo.Laboratorio.Nombre, dbo.Laboratorio.Capacidad, dbo.Laboratorio.Ubicacion, dbo.Laboratorio.Imagen, dbo.Laboratorio.IdDoc FROM   dbo.Laboratorio INNER JOIN   dbo.Personal ON dbo.Laboratorio.IdDoc = dbo.Personal.IdDoc");

            foreach (DataRow filaDato in tablaDato.Rows)
            {

                Laboratorio temporal = new Laboratorio();
                temporal.IdLaboratorio = Convert.ToInt32(filaDato["IdLaboratorio"]);
                temporal.Codigo = Convert.ToString(filaDato["Codigo"]);
                temporal.Nombre = Convert.ToString(filaDato["Nombre"]);
                temporal.Capacidad = Convert.ToInt32(filaDato["Capacidad"]);
                temporal.Ubicacion = Convert.ToString(filaDato["Ubicacion"]);
                temporal.JefeLaboratorio = Convert.ToString(filaDato["JefeLaboratorio"]);


                lista.Add(temporal);

            }
            return lista;
        }
        public static Int32 totalregistroHabi;
        public static Laboratorio EnviarLaboratorio(int codigo,string fecha)
        {
            Laboratorio Temp = new Laboratorio();
            try
            {
                Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("SELECT Laboratorio.Nombre  FROM dbo.Laboratorio INNER JOIN dbo.Asistencia ON dbo.Laboratorio.IdLaboratorio = dbo.Asistencia.IdLaboratorio where IdDoc='" + codigo + "' and Fecha='" + fecha + "'"));
            }
            catch { }
                 try
            {

                Temp.Codigo = Convert.ToString(AccesoDatos.ConsultaDato("SELECT     dbo.Laboratorio.Codigo, dbo.Laboratorio.IdDoc FROM dbo.Laboratorio INNER JOIN                       dbo.Personal ON dbo.Laboratorio.IdDoc = dbo.Personal.IdDoc WHERE     (dbo.Laboratorio.IdDoc = '" + codigo + "') "));
                 }catch{}
           
            try
            {
                Temp.JefeLaboratorio = Convert.ToString(AccesoDatos.ConsultaDato("SELECT     dbo.Laboratorio.IdDoc FROM dbo.Laboratorio INNER JOIN dbo.Personal ON dbo.Laboratorio.IdDoc = dbo.Personal.IdDoc WHERE     (dbo.Laboratorio.IdLaboratorio = '" + codigo + "') "));

            }
            catch { }


            return Temp;

        }
        public static Laboratorio EnviarLaboratorio(int codigo)
        {
            Laboratorio Temp = new Laboratorio();
            try
            {
                Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Laboratorio where IdLaboratorio='" + codigo + "' "));
            }
            catch { }
            try
            {

                Temp.Codigo = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Laboratorio where IdLaboratorio= '" + codigo + "'"));
                Temp.Capacidad = Convert.ToInt32(AccesoDatos.ConsultaDato("select Capacidad from Laboratorio where IdLaboratorio= '" + codigo + "'"));

            }
            catch { }

            return Temp;

        }
        public static bool BuscarCodigoLaboratorio(string codigo)
        {
            bool bandera = false;
            string LabCodigo="";

            LabCodigo = Convert.ToString(AccesoDatos.ConsultaDato("select Codigo from Laboratorio where Codigo= '" + codigo + "'"));
            if (LabCodigo!="")
            {
                bandera = true;
            }

            return bandera;
        }

        //PERSONAL
        public static void InsDocente(Docente Objeto)
        {
            AccesoDatos.reaOperacion("Insert Into Personal ( Dni, Nombre,ApellidoPaterno,ApellidoMaterno,Direccion,Correo,Titulo,Especialidad,Estado,Telefono,Celular,Sexo,Contraseña,IdRol,CondJefe) values('" + Objeto.Dni + "','" + Objeto.Nombre + "','" + Objeto.ApellidoPaterno + "','" + Objeto.ApellidoMaterno + "','" + Objeto.Direccion + "','" + Objeto.Correo + "','" + Objeto.Titulo + "','" + Objeto.Especialidad + "','" + Objeto.Estado + "','" + Objeto.Telefono + "','" + Objeto.Celular + "','" + Objeto.Sexo + "','" + Objeto.Contraseña + "','" + Objeto.IdRol + "','NO')");
        }
        public static void ModDocente(Docente Objeto)
        {
            try
            {
                AccesoDatos.reaOperacion("Update Personal set Dni='" + Objeto.Dni + "',Nombre='" + Objeto.Nombre + "', ApellidoPaterno='" + Objeto.ApellidoPaterno + "',ApellidoMaterno='" + Objeto.ApellidoMaterno + "', Direccion='" + Objeto.Direccion + "',Correo='" + Objeto.Correo + "',Titulo='" + Objeto.Titulo + "', Especialidad='" + Objeto.Especialidad + "',Estado='" + Objeto.Estado + "',Telefono='" + Objeto.Telefono + "',Celular='" + Objeto.Celular + "',Sexo='" + Objeto.Sexo + "',Contraseña='" + Objeto.Contraseña + "',IdRol='" + Objeto.IdRol + "' from Personal where IdDoc='" + Objeto.IdDocente + "'");
            }
            catch { }

        }
        public static void ModContraseña(Docente Objeto)
        {
            AccesoDatos.reaOperacion("Update Personal set Contraseña='" + Objeto.Contraseña + "' from Personal where IdDoc='" + Objeto.IdDocente + "'");
        }
        public static List<Docente> listaDocente(string cond)
        {

            List<Docente> lista = new List<Docente>();
            DataTable tablaDato = new DataTable();

            if (cond == "todos")
            {
                tablaDato = AccesoDatos.reaConsulVista("SELECT     dbo.Personal.*, dbo.Rol.Descripcion FROM         dbo.Personal INNER JOIN dbo.Rol ON dbo.Personal.IdRol = dbo.Rol.IdRol order by  dbo.Personal.Nombre asc ");

                foreach (DataRow filaDato in tablaDato.Rows)
                {
                    try
                    {
                        Docente temporal = new Docente();
                        temporal.IdDocente = Convert.ToInt32(filaDato["IdDoc"]);
                        temporal.Dni = Convert.ToString(filaDato["Dni"]);
                        temporal.Nombre = Convert.ToString(filaDato["Nombre"]);
                        temporal.ApellidoPaterno = Convert.ToString(filaDato["ApellidoPaterno"]);
                        temporal.ApellidoMaterno = Convert.ToString(filaDato["ApellidoMaterno"]);
                        temporal.Direccion = Convert.ToString(filaDato["Direccion"]);
                        temporal.Correo = Convert.ToString(filaDato["Correo"]);
                        temporal.Titulo = Convert.ToString(filaDato["Titulo"]);
                        temporal.Especialidad = Convert.ToString(filaDato["Especialidad"]);
                        temporal.Estado = Convert.ToString(filaDato["Estado"]);
                        temporal.Telefono = Convert.ToString(filaDato["Telefono"]);
                        temporal.Titulo = Convert.ToString(filaDato["Titulo"]);
                        temporal.Celular = Convert.ToString(filaDato["Celular"]);
                        temporal.Sexo = Convert.ToString(filaDato["Sexo"]);
                        temporal.Contraseña = Convert.ToString(filaDato["Contraseña"]);
                        temporal.IdRol = Convert.ToInt32(filaDato["IdRol"]);



                        lista.Add(temporal);
                    }
                    catch { }
                }
                return lista;
            }
            else if (cond == "")
            {

                tablaDato = AccesoDatos.reaConsulVista("SELECT     dbo.Personal.*, dbo.Rol.Descripcion FROM         dbo.Personal INNER JOIN dbo.Rol ON dbo.Personal.IdRol = dbo.Rol.IdRol where (Rol.IdRol='1' or Rol.IdRol='2') and CondJefe='NO' and Estado='ACTIVO' order by  dbo.Personal.Nombre asc");

                foreach (DataRow filaDato in tablaDato.Rows)
                {
                    try
                    {
                        Docente temporal = new Docente();
                        temporal.IdDocente = Convert.ToInt32(filaDato["IdDoc"]);
                        temporal.Dni = Convert.ToString(filaDato["Dni"]);
                        temporal.Nombre = Convert.ToString(filaDato["Nombre"]);
                        temporal.ApellidoPaterno = Convert.ToString(filaDato["ApellidoPaterno"]);
                        temporal.ApellidoMaterno = Convert.ToString(filaDato["ApellidoMaterno"]);
                        temporal.Direccion = Convert.ToString(filaDato["Direccion"]);
                        temporal.Correo = Convert.ToString(filaDato["Correo"]);
                        temporal.Titulo = Convert.ToString(filaDato["Titulo"]);
                        temporal.Especialidad = Convert.ToString(filaDato["Especialidad"]);
                        temporal.Estado = Convert.ToString(filaDato["Estado"]);
                        temporal.Telefono = Convert.ToString(filaDato["Telefono"]);
                        temporal.Titulo = Convert.ToString(filaDato["Titulo"]);
                        temporal.Celular = Convert.ToString(filaDato["Celular"]);
                        temporal.Sexo = Convert.ToString(filaDato["Sexo"]);
                        temporal.Contraseña = Convert.ToString(filaDato["Contraseña"]);
                        temporal.IdRol = Convert.ToInt32(filaDato["IdRol"]);



                        lista.Add(temporal);
                    }
                    catch { }



                }
                return lista;
            }
            else {

                tablaDato = AccesoDatos.reaConsulVista("SELECT     dbo.Personal.*, dbo.Rol.Descripcion FROM         dbo.Personal INNER JOIN dbo.Rol ON dbo.Personal.IdRol = dbo.Rol.IdRol where (Rol.IdRol='1' or Rol.IdRol='2')  and Estado='ACTIVO' order by  dbo.Personal.Nombre asc");

                foreach (DataRow filaDato in tablaDato.Rows)
                {
                    try
                    {
                        Docente temporal = new Docente();
                        temporal.IdDocente = Convert.ToInt32(filaDato["IdDoc"]);
                        temporal.Dni = Convert.ToString(filaDato["Dni"]);
                        temporal.Nombre = Convert.ToString(filaDato["Nombre"]);
                        temporal.ApellidoPaterno = Convert.ToString(filaDato["ApellidoPaterno"]);
                        temporal.ApellidoMaterno = Convert.ToString(filaDato["ApellidoMaterno"]);
                        temporal.Direccion = Convert.ToString(filaDato["Direccion"]);
                        temporal.Correo = Convert.ToString(filaDato["Correo"]);
                        temporal.Titulo = Convert.ToString(filaDato["Titulo"]);
                        temporal.Especialidad = Convert.ToString(filaDato["Especialidad"]);
                        temporal.Estado = Convert.ToString(filaDato["Estado"]);
                        temporal.Telefono = Convert.ToString(filaDato["Telefono"]);
                        temporal.Titulo = Convert.ToString(filaDato["Titulo"]);
                        temporal.Celular = Convert.ToString(filaDato["Celular"]);
                        temporal.Sexo = Convert.ToString(filaDato["Sexo"]);
                        temporal.Contraseña = Convert.ToString(filaDato["Contraseña"]);
                        temporal.IdRol = Convert.ToInt32(filaDato["IdRol"]);



                        lista.Add(temporal);
                    }
                    catch { }



                }
                return lista;
            }
        }
        public static Docente EnivarDocente(string codigo, string cond)
        {
            Docente Temp = new Docente();
            if (cond == "contraseña")
            {
                try
                {
                    Temp.IdDocente = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdDoc from Personal where Contraseña='" + codigo + "'"));
                    Temp.Dni = Convert.ToString(AccesoDatos.ConsultaDato("select Dni from Personal where Contraseña='" + codigo + "'"));
                    Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Personal where Contraseña='" + codigo + "'"));
                    Temp.ApellidoPaterno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoPaterno from Personal where Contraseña='" + codigo + "'"));
                    Temp.ApellidoMaterno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoMaterno from Personal where Contraseña='" + codigo + "'"));
                    Temp.Direccion = Convert.ToString(AccesoDatos.ConsultaDato("select Direccion from Personal where Contraseña='" + codigo + "'"));
                    Temp.Correo = Convert.ToString(AccesoDatos.ConsultaDato("select Correo from Personal where Contraseña='" + codigo + "'"));
                    Temp.Titulo = Convert.ToString(AccesoDatos.ConsultaDato("select Titulo from Personal where Contraseña='" + codigo + "'"));
                    Temp.Especialidad = Convert.ToString(AccesoDatos.ConsultaDato("select Especialidad from Personal where Contraseña='" + codigo + "'"));
                    Temp.Estado = Convert.ToString(AccesoDatos.ConsultaDato("select Estado from Personal where Contraseña='" + codigo + "'"));
                    Temp.Telefono = Convert.ToString(AccesoDatos.ConsultaDato("select Telefono from Personal where Contraseña='" + codigo + "'"));
                    Temp.Celular = Convert.ToString(AccesoDatos.ConsultaDato("select Celular from Personal where Contraseña='" + codigo + "'"));
                    Temp.Sexo = Convert.ToString(AccesoDatos.ConsultaDato("select Sexo from Personal where Dni='" + codigo + "'"));
                    Temp.Contraseña = Convert.ToString(AccesoDatos.ConsultaDato("select Contraseña from Personal where Contraseña='" + codigo + "'"));
                    Temp.IdRol = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdRol from Personal where Contraseña='" + codigo + "'"));
                }
                catch { }

                return Temp;
            }
            else if (cond == "dni")
            {
                try
                {

                    Temp.IdDocente = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdDoc from Personal where Dni='" + codigo + "'"));
                    Temp.Dni = Convert.ToString(AccesoDatos.ConsultaDato("select Dni from Personal where Dni='" + codigo + "'"));
                    Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Personal where Dni='" + codigo + "'"));
                    Temp.ApellidoPaterno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoPaterno from Personal where Dni='" + codigo + "'"));
                    Temp.ApellidoMaterno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoMaterno from Personal where Dni='" + codigo + "'"));
                    Temp.Direccion = Convert.ToString(AccesoDatos.ConsultaDato("select Direccion from Personal where Dni='" + codigo + "'"));
                    Temp.Correo = Convert.ToString(AccesoDatos.ConsultaDato("select Correo from Personal where Dni='" + codigo + "'"));
                    Temp.Titulo = Convert.ToString(AccesoDatos.ConsultaDato("select Titulo from Personal where Dni='" + codigo + "'"));
                    Temp.Especialidad = Convert.ToString(AccesoDatos.ConsultaDato("select Especialidad from Personal where Dni='" + codigo + "'"));
                    Temp.Estado = Convert.ToString(AccesoDatos.ConsultaDato("select Estado from Personal where Dni='" + codigo + "'"));
                    Temp.Telefono = Convert.ToString(AccesoDatos.ConsultaDato("select Telefono from Personal where Dni='" + codigo + "'"));
                    Temp.Celular = Convert.ToString(AccesoDatos.ConsultaDato("select Celular from Personal where Dni='" + codigo + "'"));
                    Temp.Sexo = Convert.ToString(AccesoDatos.ConsultaDato("select Sexo from Personal where Dni='" + codigo + "'"));
                    Temp.Contraseña = Convert.ToString(AccesoDatos.ConsultaDato("select Contraseña from Personal where Dni='" + codigo + "'"));
                    Temp.IdRol = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdRol from Personal where Dni='" + codigo + "'"));
                }
                catch { }

                return Temp;


            }
            else {

                try
                {

                    Temp.IdDocente = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdDoc from Personal where IdDoc='" + codigo + "'"));
                    Temp.Dni = Convert.ToString(AccesoDatos.ConsultaDato("select Dni from Personal where IdDoc='" + codigo + "'"));
                    Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Personal where IdDoc='" + codigo + "'"));
                    Temp.ApellidoPaterno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoPaterno from Personal where IdDoc='" + codigo + "'"));
                    Temp.ApellidoMaterno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoMaterno from Personal where IdDoc='" + codigo + "'"));
                    Temp.Direccion = Convert.ToString(AccesoDatos.ConsultaDato("select Direccion from Personal where IdDoc='" + codigo + "'"));
                    Temp.Correo = Convert.ToString(AccesoDatos.ConsultaDato("select Correo from Personal where IdDoc='" + codigo + "'"));
                    Temp.Titulo = Convert.ToString(AccesoDatos.ConsultaDato("select Titulo from Personal where IdDoc='" + codigo + "'"));
                    Temp.Especialidad = Convert.ToString(AccesoDatos.ConsultaDato("select Especialidad from Personal where IdDoc='" + codigo + "'"));
                    Temp.Estado = Convert.ToString(AccesoDatos.ConsultaDato("select Estado from Personal where IdDoc='" + codigo + "'"));
                    Temp.Telefono = Convert.ToString(AccesoDatos.ConsultaDato("select Telefono from Personal where IdDoc='" + codigo + "'"));
                    Temp.Celular = Convert.ToString(AccesoDatos.ConsultaDato("select Celular from Personal where IdDoc='" + codigo + "'"));
                    Temp.Sexo = Convert.ToString
(AccesoDatos.ConsultaDato("select Sexo from Personal where Dni='" + codigo + "'"));
                    Temp.Contraseña = Convert.ToString(AccesoDatos.ConsultaDato("select Contraseña from Personal where IdDoc='" + codigo + "'"));
                    Temp.IdRol = Convert.ToInt32
(AccesoDatos.ConsultaDato("select IdRol from Personal where IdDoc='" + codigo + "'"));
                }
                catch { }

                return Temp;
            
            }

        }
        //ALUMNO
        public static void InsAlumno(Alumno ObjDocente)
        {
            try
            {
                AccesoDatos.reaOperacion("Insert Into Alumnos (Nombre, ApellidoPaterno, ApellidoMaterno, Dni, Procedencia, IdRol, Telefono, Celular, Sexo,CondInscripcion) values('" + ObjDocente.Nombre + "','" + ObjDocente.Paterno + "','" + ObjDocente.Materno + "','" + ObjDocente.Dni + "','" + ObjDocente.Procedencia + "','" + ObjDocente.IdRol + "','" + ObjDocente.Telefono + "','" + ObjDocente.Celular + "','" + ObjDocente.Sexo + "','NO INSCRITO')");
            }
            catch { }
        }
        public static void ModAlumno(Alumno ObjDocente)
        {
            try
            {
                AccesoDatos.reaOperacion("Update Alumnos set Nombre='" + ObjDocente.Nombre + "',ApellidoPaterno='" + ObjDocente.Paterno + "', ApellidoMaterno='" + ObjDocente.Materno + "',Dni='" + ObjDocente.Dni + "', Procedencia='" + ObjDocente.Procedencia + "', IdRol='" + ObjDocente.IdRol + "', Telefono='" + ObjDocente.Telefono + "',Celular='" + ObjDocente.Celular + "' Where IdAlumno='" + ObjDocente.IdAlumno + "'");
            }
            catch { }

        }
        public static List<Alumno> lisAlumno(string condicion)
        {
            List<Alumno> lisAlumno = new List<Alumno>();
            DataTable dtPro = new DataTable();

            if(condicion=="todos")
            {
            dtPro = AccesoDatos.reaConsulVista("Select * from Alumnos");

            foreach (DataRow drPro in dtPro.Rows)
            {

                Alumno tmpAlumno = new Alumno();

                tmpAlumno.IdAlumno = Convert.ToInt32(drPro["IdAlumno"]);
                tmpAlumno.Nombre = Convert.ToString(drPro["Nombre"]);
                tmpAlumno.Paterno = Convert.ToString(drPro["ApellidoPaterno"]);
                tmpAlumno.Materno = Convert.ToString(drPro["ApellidoMaterno"]);
                tmpAlumno.Dni = Convert.ToInt32(drPro["Dni"]);
                tmpAlumno.Procedencia = Convert.ToString(drPro["Procedencia"]);
                tmpAlumno.IdRol = Convert.ToInt32(drPro["IdRol"]);
                tmpAlumno.Telefono = Convert.ToString(drPro["Telefono"]);
                tmpAlumno.Celular = Convert.ToString(drPro["Celular"]);
                tmpAlumno.Sexo = Convert.ToString(drPro["Sexo"]);

                lisAlumno.Add(tmpAlumno);

            }
            return lisAlumno;
            }else{

                dtPro = AccesoDatos.reaConsulVista("Select * from Alumnos");

                foreach (DataRow drPro in dtPro.Rows)
                {

                    Alumno tmpAlumno = new Alumno();

                    tmpAlumno.IdAlumno = Convert.ToInt32(drPro["IdAlumno"]);
                    tmpAlumno.Nombre = Convert.ToString(drPro["Nombre"]);
                    tmpAlumno.Paterno = Convert.ToString(drPro["ApellidoPaterno"]);
                    tmpAlumno.Materno = Convert.ToString(drPro["ApellidoMaterno"]);
                    tmpAlumno.Dni = Convert.ToInt32(drPro["Dni"]);
                    tmpAlumno.Procedencia = Convert.ToString(drPro["Procedencia"]);
                    tmpAlumno.IdRol = Convert.ToInt32(drPro["IdRol"]);
                    tmpAlumno.Telefono = Convert.ToString(drPro["Telefono"]);
                    tmpAlumno.Celular = Convert.ToString(drPro["Celular"]);
                    tmpAlumno.Sexo = Convert.ToString(drPro["Sexo"]);

                    lisAlumno.Add(tmpAlumno);

                }
                return lisAlumno;
            
            
            
            
            
            
            }
        }
        public static Alumno EnviarAlumno(string codigo, string condi)
        {
            Alumno Temp = new Alumno();

            if (condi=="id")
            {
            try
            {
                Temp.IdAlumno = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdAlumno from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.Paterno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoPaterno from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.Materno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoMaterno from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.Dni = Convert.ToInt32(AccesoDatos.ConsultaDato("select Dni from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.Procedencia = Convert.ToString(AccesoDatos.ConsultaDato("select Procedencia from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.IdRol = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdRol from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.Telefono = Convert.ToString(AccesoDatos.ConsultaDato("select Telefono from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.Celular = Convert.ToString(AccesoDatos.ConsultaDato("select Celular from Alumnos where IdAlumno='" + codigo + "'"));
                Temp.CondInscripcion = Convert.ToString(AccesoDatos.ConsultaDato("select CondInscripcion from Alumnos where IdAlumno='" + codigo + "'"));
            }
            catch { }
            }else{ 
            
            try
            {
                Temp.IdAlumno = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdAlumno from Alumnos where Dni='" + codigo + "'"));
                Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Alumnos where Dni='" + codigo + "'"));
                Temp.Paterno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoPaterno from Alumnos where Dni='" + codigo + "'"));
                Temp.Materno = Convert.ToString(AccesoDatos.ConsultaDato("select ApellidoMaterno from Alumnos where Dni='" + codigo + "'"));
                Temp.Dni = Convert.ToInt32(AccesoDatos.ConsultaDato("select Dni from Alumnos where Dni='" + codigo + "'"));
                Temp.Procedencia = Convert.ToString(AccesoDatos.ConsultaDato("select Procedencia from Alumnos where Dni='" + codigo + "'"));
                Temp.IdRol = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdRol from Alumnos where Dni='" + codigo + "'"));
                Temp.Telefono = Convert.ToString(AccesoDatos.ConsultaDato("select Telefono from Alumnos where Dni='" + codigo + "'"));
                Temp.Celular = Convert.ToString(AccesoDatos.ConsultaDato("select Celular from Alumnos where Dni='" + codigo + "'"));
                Temp.CondInscripcion = Convert.ToString(AccesoDatos.ConsultaDato("select CondInscripcion from Alumnos where Dni='" + codigo + "'"));
            }
            catch { }}

            return Temp;

        }
        //ROL
        public static List<Rol> lisRol(String condicion)
        {
            List<Rol> lisAlumno = new List<Rol>();
            DataTable dtPro = new DataTable();
            if (condicion=="1")
            {

                dtPro = AccesoDatos.reaConsulVista("Select * from Rol where Descripcion='ALUMNO' ");

            foreach (DataRow drPro in dtPro.Rows)
            {
                Rol tmpAlumno = new Rol();
                tmpAlumno.IdRol = Convert.ToInt32(drPro["IdRol"]);
                tmpAlumno.Descripcion = Convert.ToString(drPro["Descripcion"]);
                lisAlumno.Add(tmpAlumno);

            }
            }
            else if (condicion == "2")
            {

                dtPro = AccesoDatos.reaConsulVista("Select * from Rol where Descripcion<>'PRACTICANTE' and Descripcion<>'BOLSISTA'and Descripcion<>'ALUMNO'");

                foreach (DataRow drPro in dtPro.Rows)
                {
                    Rol tmpAlumno = new Rol();
                    tmpAlumno.IdRol = Convert.ToInt32(drPro["IdRol"]);
                    tmpAlumno.Descripcion = Convert.ToString(drPro["Descripcion"]);
                    lisAlumno.Add(tmpAlumno);

                }

            }
            else {

                dtPro = AccesoDatos.reaConsulVista("Select * from Rol  where Descripcion<>'ALUMNO'");

                foreach (DataRow drPro in dtPro.Rows)
                {
                    Rol tmpAlumno = new Rol();
                    tmpAlumno.IdRol = Convert.ToInt32(drPro["IdRol"]);
                    tmpAlumno.Descripcion = Convert.ToString(drPro["Descripcion"]);
                    lisAlumno.Add(tmpAlumno);

                }
            }
            return lisAlumno;
        }
        //CURSO
        public static int CantCursos()
        {
            int Cant = Convert.ToInt32(AccesoDatos.ConsultaDato("select count(IdCurso) from Curso"));
            return Cant;
        }
        public static void ModCursos(Curso ObjUsuario,string cond )
        {
            try
            {
                AccesoDatos.reaOperacion("Update Curso set Nombre='" + ObjUsuario.Nombre + "',Codigo='" + ObjUsuario.Codigo + "',Creditos='" + ObjUsuario.Creditos + "',Abreviatura='" + ObjUsuario.Abreviatura + "'  from Curso where IdCurso='" + ObjUsuario.IdCurso + "'");
            }
            catch { }

          
            



            if(cond != "SEMESTRAL")
            {
                try
                {
                    AccesoDatos.reaOperacion("Update CostoCurso set Estado='INACTIVO'  from CostoCurso where Estado='ACTIVO' and IdCurso='" + ObjUsuario.IdCurso + "'");
                }
                catch { }




            try
            {

                AccesoDatos.reaOperacion("Insert Into CostoCurso (IdCurso, Costo, FechaRegistro,FechaMes,FechaAño,Estado) values('" + ObjUsuario.IdCurso + "','" + ObjUsuario.Costo + "','" + DateTime.Now + "','" + DateTime.Now.Month + "','" + DateTime.Now.Year + "','ACTIVO')");
            }
            catch { }
            }

        }
        public static void InsCurso(Curso ObjDocente)
         {
            try
            {
                try
                    {
                        AccesoDatos.reaOperacion("Insert Into Curso (Codigo, Nombre, Creditos, Tipo,Estado,Abreviatura) values('" + ObjDocente.Codigo + "','" + ObjDocente.Nombre + "','" + ObjDocente.Creditos + "','" + ObjDocente.Tipo + "','ACTIVO','" + ObjDocente.Abreviatura + "')");
                    }
                    catch { }

                ObjDocente.IdCurso = CantCursos();
                    try
                    {

                        AccesoDatos.reaOperacion("Insert Into CostoCurso (IdCurso, Costo, FechaRegistro,FechaMes,FechaAño,Estado) values('" + ObjDocente.IdCurso + "','" + ObjDocente.Costo + "','" + DateTime.Now + "','" + DateTime.Now.Month + "','" + DateTime.Now.Year + "','ACTIVO')");
                    }
                    catch { }

                
                

            }
            catch { }
        }
        public static List<Curso> listCursos(string cond,string semestre)
        {
            List<Curso> lisAlumno = new List<Curso>();
            DataTable dtPro = new DataTable();

            if(cond=="todos")
            {
                dtPro = AccesoDatos.reaConsulVista("SELECT     TOP (100) PERCENT dbo.CostoCurso.IdCostoCurso, dbo.CostoCurso.IdCurso, dbo.CostoCurso.Costo, dbo.CostoCurso.FechaRegistro, dbo.Curso.Codigo, dbo.Curso.Abreviatura, dbo.Curso.Nombre,                       dbo.Curso.Creditos, dbo.Curso.Tipo, dbo.Curso.Estado FROM         dbo.CostoCurso INNER JOIN       dbo.Curso ON dbo.CostoCurso.IdCurso = dbo.Curso.IdCurso WHERE     (dbo.Curso.Estado = 'ACTIVO') AND (dbo.CostoCurso.Estado = 'ACTIVO') ORDER BY dbo.CostoCurso.FechaRegistro DESC");

            foreach (DataRow drPro in dtPro.Rows)
            {

                Curso tmpAlumno = new Curso();

                tmpAlumno.IdCurso = Convert.ToInt32(drPro["IdCurso"]);
                tmpAlumno.Codigo = Convert.ToString(drPro["Codigo"]);
                tmpAlumno.Nombre = Convert.ToString(drPro["Nombre"]);
                tmpAlumno.Creditos = Convert.ToInt32(drPro["Creditos"]);
                tmpAlumno.Tipo = Convert.ToString(drPro["Tipo"]);
                tmpAlumno.Costo = Convert.ToDouble(drPro["Costo"]);
                tmpAlumno.Estado = Convert.ToString(drPro["Estado"]);
                tmpAlumno.Abreviatura = Convert.ToString(drPro["Abreviatura"]);
                tmpAlumno.FechaRegistro = Convert.ToDateTime(drPro["FechaRegistro"]);

                lisAlumno.Add(tmpAlumno);

            }
            return lisAlumno;
            }else{


                dtPro = AccesoDatos.reaConsulVista("SELECT     TOP (100) PERCENT dbo.ProgramacionCurso.IdDisponibilidad,dbo.ProgramacionCurso.IdCurso, dbo.Curso.Codigo, dbo.Curso.Nombre, dbo.ProgramacionCurso.FechaInicio, dbo.ProgramacionCurso.FechaFinal, dbo.Curso.Tipo,   dbo.Personal.IdDoc,                      dbo.Personal.Nombre AS Profesor, dbo.Personal.ApellidoPaterno, dbo.Personal.ApellidoMaterno, dbo.CostoCurso.Costo FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.Personal ON dbo.ProgramacionCurso.IdDoc = dbo.Personal.IdDoc INNER JOIN                       dbo.CostoCurso ON dbo.Curso.IdCurso = dbo.CostoCurso.IdCurso WHERE     (dbo.Curso.Estado = 'ACTIVO') AND (dbo.CostoCurso.Estado = 'ACTIVO') and dbo.ProgramacionCurso.FechaFinal>='" + DateTime.Now.ToShortDateString() + "'  and ProgramacionCurso.IdSemestre='" + semestre + "' ORDER BY dbo.CostoCurso.FechaRegistro DESC");

            foreach (DataRow drPro in dtPro.Rows)
            {

                Curso tmpAlumno = new Curso();

                tmpAlumno.IdCurso = Convert.ToInt32(drPro["IdCurso"]);
                tmpAlumno.Codigo = Convert.ToString(drPro["Codigo"]);
                tmpAlumno.Nombre = Convert.ToString(drPro["Nombre"]);
                tmpAlumno.Tipo = Convert.ToString(drPro["Tipo"]);
                tmpAlumno.Costo = Convert.ToDouble(drPro["Costo"]);
                tmpAlumno.FechaInicial = Convert.ToDateTime(drPro["FechaInicio"]);
                tmpAlumno.FechaFinal = Convert.ToDateTime(drPro["FechaFinal"]);
                tmpAlumno.Profesor = Convert.ToString(drPro["Profesor"] + " " + Convert.ToString(drPro["ApellidoPaterno"]) + " " + Convert.ToString(drPro["ApellidoMaterno"]));
                tmpAlumno.Idprofesor = Convert.ToString(drPro["IdDoc"]);
                tmpAlumno.IdDisponibilidad = Convert.ToString(drPro["IdDisponibilidad"]);
                
                
                lisAlumno.Add(tmpAlumno);

            }
            return lisAlumno;
            }
        }
        public static Curso EnviarCurso(string codigo,string condi)
        {
            Curso Temp = new Curso();
            if(condi=="")
            {
            try
            {
                Temp.IdCurso = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdCurso from Curso where Codigo='" + codigo + "'"));
                Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Curso where Codigo='" + codigo + "'"));
                Temp.Creditos = Convert.ToInt32(AccesoDatos.ConsultaDato("select Creditos from Curso where Codigo='" + codigo + "'"));
                Temp.Tipo = Convert.ToString(AccesoDatos.ConsultaDato("select Tipo from Curso where Codigo='" + codigo + "'"));
                Temp.Codigo = Convert.ToString(AccesoDatos.ConsultaDato("select Codigo from Curso where Codigo='" + codigo + "'"));
                Temp.Costo = Convert.ToDouble(AccesoDatos.ConsultaDato("SELECT     dbo.CostoCurso.Costo FROM dbo.Curso INNER JOIN dbo.CostoCurso ON dbo.Curso.IdCurso = dbo.CostoCurso.IdCurso where Curso.Codigo='" + codigo + "'"));

            }
            catch { }

            return Temp;
            }else{
            
            try
            {
                Temp.IdCurso = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdCurso from Curso where IdCurso='" + codigo + "'"));
                Temp.Nombre = Convert.ToString(AccesoDatos.ConsultaDato("select Nombre from Curso where IdCurso='" + codigo + "'"));
                Temp.Creditos = Convert.ToInt32(AccesoDatos.ConsultaDato("select Creditos from Curso where IdCurso='" + codigo + "'"));
                Temp.Tipo = Convert.ToString(AccesoDatos.ConsultaDato("select Tipo from Curso where IdCurso='" + codigo + "'"));
                Temp.Codigo = Convert.ToString(AccesoDatos.ConsultaDato("select Codigo from Curso where IdCurso='" + codigo + "'"));

            }
            catch { }

            return Temp;
            
            }

        }
        //ASISTENCIA
        public static void InsAsistencia(Asistencia Objeto, int codigo)
        {
            try
            {
                if (Objeto.Estado == "")
                {
                    try
                    {
                        AccesoDatos.reaOperacion("Insert Into Asistencia ( IdDoc, IdLaboratorio,Fecha,HoraIngreso,HoraSalida,Observacion,Estado,Condicion,SustInasistencia,ClasificacionAsistencia) values('" + Objeto.IdPersonal + "','" + Objeto.IdLaboratorio + "','" + Objeto.Fecha + "','" + Objeto.HoraIngreso + "','" + Objeto.HoraIngreso + "','" + Objeto.Observacion + "','','1','','" + Objeto.Clasificacion + "')");
                    }
                    catch { }
                }

                else
                {

                    try
                    {

                        AccesoDatos.reaOperacion("Update Asistencia set HoraSalida='" + Objeto.HoraSalida + "', Estado='" + Objeto.Estado + "', Observacion ='" + Objeto.Observacion + "', Condicion ='" + 2 + "' from Asistencia where IdDoc='" + codigo + "' and Fecha='" + Objeto.Fecha + "'");
                    }
                    catch { }


                }
            }
            catch { }

        }
        public static Asistencia EnviarAsistencia(string codigo)
        {
            Asistencia Temp = new Asistencia();
            try
            {
                Temp.HoraIngreso = Convert.ToDateTime(AccesoDatos.ConsultaDato("select HoraIngreso from Asistencia where IdAsistencia='" + codigo + "' "));
            }
            catch { }
            try
            {

                Temp.HoraSalida = Convert.ToDateTime(AccesoDatos.ConsultaDato("select HoraSalida from Asistencia where IdAsistencia= '" + codigo + "'"));
                

            }
            catch { }

            return Temp;

        }
        public static void ModAsistencia(Asistencia Objeto)
        {
            try
            {
                AccesoDatos.reaOperacion("Update Asistencia set HoraSalida='" + Objeto.HoraSalida + "',HoraIngreso='" + Objeto.HoraIngreso + "',SustInasistencia='" + Objeto.Observacion + "',ClasificacionAsistencia='PUNTUAL' from Asistencia where IdAsistencia='" + Objeto.IdAsistencia + "'");
            }
            catch { }

        }
        public static Asistencia EnviarHoraPersonal(string contraseña,DateTime fecha)
        {
            Asistencia Temp = new Asistencia();
            try
            {
                try
                {
                    Temp.HoraIngreso = Convert.ToDateTime(AccesoDatos.ConsultaDato("SELECT HoraIngreso FROM dbo.Asistencia INNER JOIN dbo.Personal ON dbo.Asistencia.IdDoc = dbo.Personal.IdDoc where Personal.Contraseña='" + contraseña + "' and Asistencia.Fecha='" + fecha + "'"));
                }
                catch { }

                try
                {

                    Temp.HoraSalida = Convert.ToDateTime(AccesoDatos.ConsultaDato("SELECT HoraSalida FROM dbo.Asistencia INNER JOIN dbo.Personal ON dbo.Asistencia.IdDoc = dbo.Personal.IdDoc where Personal.Contraseña='" + contraseña + "' and Asistencia.Fecha='" + fecha + "'"));
                }
                catch { }

                Temp.Estado = Convert.ToString(AccesoDatos.ConsultaDato("SELECT Asistencia.Estado FROM dbo.Asistencia INNER JOIN dbo.Personal ON dbo.Asistencia.IdDoc = dbo.Personal.IdDoc where Personal.Contraseña='" + contraseña + "' and Asistencia.Fecha='" + fecha + "'"));

                Temp.Fecha = Convert.ToDateTime(AccesoDatos.ConsultaDato("SELECT Asistencia.Fecha FROM dbo.Asistencia INNER JOIN dbo.Personal ON dbo.Asistencia.IdDoc = dbo.Personal.IdDoc where Personal.Contraseña='" + contraseña + "' and Asistencia.Fecha='" + fecha + "'"));

                Temp.Observacion = Convert.ToString(AccesoDatos.ConsultaDato("SELECT Asistencia.Observacion FROM dbo.Asistencia INNER JOIN dbo.Personal ON dbo.Asistencia.IdDoc = dbo.Personal.IdDoc where Personal.Contraseña='" + contraseña + "' and Asistencia.Fecha='" + fecha + "'"));

                Temp.Condicion = Convert.ToInt32(AccesoDatos.ConsultaDato("SELECT Asistencia.Condicion FROM dbo.Asistencia INNER JOIN dbo.Personal ON dbo.Asistencia.IdDoc = dbo.Personal.IdDoc where Personal.Contraseña='" + contraseña + "' and Asistencia.Fecha='" + fecha + "'"));



            }
            catch { }

            return Temp;

        }
        public static List<VistaAsistencia> lisAsistencia(int codigo)
        {
            List<VistaAsistencia> lisAlumno = new List<VistaAsistencia>();
            DataTable dtPro = new DataTable();
            dtPro = AccesoDatos.reaConsulVista("SELECT Asistencia.IdAsistencia, dbo.Personal.IdDoc, dbo.Personal.Dni AS DNI, dbo.Personal.Nombre AS Nombre, dbo.Personal.ApellidoPaterno AS Apellido, dbo.Asistencia.Fecha, dbo.Asistencia.HoraIngreso, dbo.Asistencia.HoraSalida, dbo.Laboratorio.Nombre AS Laboratorio,dbo.Asistencia.ClasificacionAsistencia as Estado FROM dbo.Asistencia INNER JOIN dbo.Personal ON dbo.Asistencia.IdDoc = dbo.Personal.IdDoc INNER JOIN dbo.Laboratorio ON dbo.Asistencia.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE     (dbo.Personal.IdDoc = '" + codigo + "' ) order by Fecha asc");

            foreach (DataRow drPro in dtPro.Rows)
            {

                VistaAsistencia tmpAlumno = new VistaAsistencia();
                tmpAlumno.IdAsistencia = Convert.ToInt32(drPro["IdAsistencia"]);
                tmpAlumno.IdPersonal = Convert.ToInt32(drPro["IdDoc"]);
                tmpAlumno.Nombre = Convert.ToString(drPro["Nombre"]);
                tmpAlumno.Apellido = Convert.ToString(drPro["Apellido"]);
                tmpAlumno.Fecha = Convert.ToString(drPro["Fecha"]);
                tmpAlumno.Dni = Convert.ToString(drPro["DNI"]);
                tmpAlumno.HoraIngreso = Convert.ToDateTime(drPro["HoraIngreso"]);
                tmpAlumno.HoraSalida = Convert.ToDateTime(drPro["HoraSalida"]);
                tmpAlumno.Laboratorio = Convert.ToString(drPro["Laboratorio"]);
                tmpAlumno.EstadoAsistencia = Convert.ToString(drPro["Estado"]);

                lisAlumno.Add(tmpAlumno);

            }
            return lisAlumno;
        }
        public static int EnviarTardanza(int docente)
        {
            int Temp =0;
            try
            {
                Temp = Convert.ToInt32(AccesoDatos.ConsultaDato("SELECT COUNT(IdDoc) FROM Asistencia where ClasificacionAsistencia='TARDANZA' and IdDoc='" + docente + "'"));
            }
            catch { }
           

            return Temp;

        }
        //INSCRIPCION
        public static void InsInscripcion(Inscripcion Objeto)
        {
            try
            {
                AccesoDatos.reaOperacion("Insert Into Inscripcion ( IdCurso, IdAlumno,Estado,FechaInscripcion,IdSemestre,IdDisponibilidad) values('" + Objeto.IdCurso + "','" + Objeto.IdAlumno + "','" + Objeto.Estado + "','" + Objeto.FechaInscripcion + "','" + Objeto.Semestre + "','" + Objeto.Disponibilidad + "')");

            }
            catch { }

        }
        public static int CantInscripciones()
        {
            int Cant = Convert.ToInt32(AccesoDatos.ConsultaDato("select count(IdInscripcion) from Inscripcion"));
            return Cant;
        }
        public static void ModInscripcion(Inscripcion Objeto)
        {
            AccesoDatos.reaOperacion("Update Inscripcion set IdCurso='" + Objeto.IdCurso + "',IdAlumno='" + Objeto.IdAlumno + "' from Inscripcion where IdInscripcion='" + Objeto.IdInscripcion + "'");

        }
        public static List<Inscripcion> listaInscripcion()
        {

            List<Inscripcion> lista = new List<Inscripcion>();
            DataTable tablaDato = new DataTable();
            tablaDato = AccesoDatos.reaConsulVista("SELECT     TOP (100) PERCENT dbo.Inscripcion.IdSemestre, dbo.Inscripcion.IdInscripcion, dbo.Inscripcion.IdCurso, dbo.Inscripcion.IdAlumno, dbo.Inscripcion.Estado, dbo.Alumnos.Nombre,                       dbo.Alumnos.ApellidoPaterno, dbo.Alumnos.ApellidoMaterno, dbo.Curso.Codigo, dbo.Curso.Nombre AS Curso FROM         dbo.Inscripcion INNER JOIN dbo.Curso ON dbo.Inscripcion.IdCurso = dbo.Curso.IdCurso INNER JOIN dbo.Alumnos ON dbo.Inscripcion.IdAlumno = dbo.Alumnos.IdAlumno INNER JOIN dbo.ProgramacionCurso ON dbo.Inscripcion.IdDisponibilidad = dbo.ProgramacionCurso.IdDisponibilidad AND dbo.Curso.IdCurso = dbo.ProgramacionCurso.IdCurso where dbo.ProgramacionCurso.FechaFinal>='"+DateTime.Now+"'");

            foreach (DataRow filaDato in tablaDato.Rows)
            {

                Inscripcion temporal = new Inscripcion();
                temporal.IdInscripcion = Convert.ToInt32(filaDato["IdInscripcion"]);
                temporal.IdCurso = Convert.ToInt32(filaDato["IdCurso"]);
                temporal.IdAlumno = Convert.ToInt32(filaDato["IdAlumno"]);
                temporal.Estado = Convert.ToString(filaDato["Estado"]);
                temporal.CodigoCurso = Convert.ToString(filaDato["Codigo"]);
                temporal.NombreCurso = Convert.ToString(filaDato["Curso"]);
                temporal.NombreAlumno = Convert.ToString(filaDato["Nombre"] + "  " + filaDato["ApellidoPaterno"] + "  " + filaDato["ApellidoMaterno"]);
                temporal.Semestre =EnviarSemestre( Convert.ToString(filaDato["IdSemestre"])).Descripcion;


                lista.Add(temporal);

            }
            return lista;
        }
        public static Inscripcion EnviarInscripcion(string codigo)
        {
            Inscripcion Temp = new Inscripcion();
            try
            {
                Temp.IdCurso = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdCurso from Inscripcion where IdInscripcion='" + codigo + "'"));
                Temp.IdAlumno = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdAlumno from Inscripcion where IdInscripcion='" + codigo + "'"));
                Temp.Estado = Convert.ToString(AccesoDatos.ConsultaDato("select Estado from Inscripcion where IdInscripcion='" + codigo + "'"));
                Temp.FechaInscripcion = Convert.ToDateTime(AccesoDatos.ConsultaDato("select FechaInscripcion from Inscripcion where IdInscripcion='" + codigo + "'"));
                Temp.CostoTotal = Convert.ToDouble(AccesoDatos.ConsultaDato("select CostoTotal from Inscripcion where IdInscripcion='" + codigo + "'"));

            }
            catch { }

            return Temp;

        }
        public static Inscripcion EnviarInscripcionAlumno(string alumno, string curso, string semestre,string disponibilidad)
        {
            Inscripcion Temp = new Inscripcion();
            Temp.Bandera = false;
            for (int i = 1; i <= CantInscripciones();i++ )
            {

                try
                {
                    Temp.IdCurso = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdCurso from Inscripcion where IdInscripcion='" + i + "'"));
                    Temp.IdAlumno = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdAlumno from Inscripcion where IdInscripcion='" + i + "'"));
                    Temp.Semestre = Convert.ToString(AccesoDatos.ConsultaDato("select IdSemestre from Inscripcion where IdInscripcion='" + i + "'"));
                    Temp.Disponibilidad = Convert.ToString(AccesoDatos.ConsultaDato("select IdDisponibilidad from Inscripcion where IdInscripcion='" + i + "'"));
                   
                }
                catch { }

                if (Temp.IdCurso.ToString() == curso && Temp.IdAlumno.ToString() == alumno && Temp.Semestre == semestre && Temp.Disponibilidad == (disponibilidad))
                    {
                            Temp.Bandera = true;
                            return Temp;
                    }
                


            } 

            return Temp;

        }
        //CONTROLPAGOS
        public static List<VerPagos> listPagos(string codigo)
        {
            List<VerPagos> lisAlumno = new List<VerPagos>();
            DataTable dtPro = new DataTable();
            dtPro = AccesoDatos.reaConsulVista("SELECT     dbo.ControlPagos.FechaPago, dbo.ControlPagos.Monto FROM dbo.ControlPagos INNER JOIN dbo.Inscripcion ON dbo.ControlPagos.IdInscripcion = dbo.Inscripcion.IdInscripcion where Inscripcion.IdInscripcion='" + codigo + "'");

            foreach (DataRow drPro in dtPro.Rows)
            {

                VerPagos tmpAlumno = new VerPagos();

                tmpAlumno.Fecha = Convert.ToDateTime(drPro["FechaPago"]);
                tmpAlumno.Monto = Convert.ToDouble(drPro["Monto"]);

                lisAlumno.Add(tmpAlumno);

            }
            return lisAlumno;
        }
        public static void InsInscripcionPagos(Inscripcion Objeto)
        {
            
                double Costo = Convert.ToDouble(AccesoDatos.ConsultaDato("SELECT   CostoCurso.Costo  FROM         dbo.CostoCurso INNER JOIN dbo.Curso ON dbo.CostoCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN dbo.Inscripcion ON dbo.Curso.IdCurso = dbo.Inscripcion.IdCurso where Inscripcion.IdInscripcion='" + Objeto.IdInscripcion + "'"));

                double costogeneral = Convert.ToDouble(AccesoDatos.ConsultaDato("SELECT     CostoTotal FROM dbo.Inscripcion where Inscripcion.IdInscripcion='" + Objeto.IdInscripcion + "'"));

                if ((costogeneral + Objeto.CostoTotal) == Costo)
            {
                try
                {
                    AccesoDatos.reaOperacion("Insert Into ControlPagos ( IdInscripcion, Monto,FechaPago) values('" + Objeto.IdInscripcion + "','" + Objeto.CostoTotal + "','" + Objeto.FechaInscripcion + "')");

                    costogeneral = costogeneral + Objeto.CostoTotal;

                    try
                    {
                        AccesoDatos.reaOperacion("Update Inscripcion set Estado='CANCELADO' , CostoTotal='" + costogeneral + "' from Inscripcion where IdInscripcion='" + Objeto.IdInscripcion + "'");
                    }
                    catch { }

                }
                catch { }
            }
            else
            {

                try
                {
                    AccesoDatos.reaOperacion("Insert Into ControlPagos ( IdInscripcion, Monto,FechaPago) values('" + Objeto.IdInscripcion + "','" + Objeto.CostoTotal + "','" + Objeto.FechaInscripcion + "')");
                }
                catch { }



                costogeneral = costogeneral + Objeto.CostoTotal;

                try
                {
                    AccesoDatos.reaOperacion("Update Inscripcion set CostoTotal='" + costogeneral + "' from Inscripcion where IdInscripcion='" + Objeto.IdInscripcion + "'");
                }
                catch { }

            }

        }
        // MES
        public static List<Mes> lisMes()
        {
            List<Mes> lstPro = new List<Mes>();
            DataTable dtPro = new DataTable();

            dtPro = AccesoDatos.reaConsulVista("select CodMes, Descripcion from Mes");

            foreach (DataRow drPro in dtPro.Rows)
            {
                Mes tmpProd = new Mes();

                tmpProd.Codigo = Convert.ToInt32(drPro["CodMes"]);
                tmpProd.Nombre = Convert.ToString(drPro["Descripcion"]);


                lstPro.Add(tmpProd);
            }

            return lstPro;
        }
        // DIA
        public static List<Mes> lisDias()
        {
            List<Mes> lstPro = new List<Mes>();
            DataTable dtPro = new DataTable();

            dtPro = AccesoDatos.reaConsulVista("select IdFechaDia,Descripcion from FechaDia");

            foreach (DataRow drPro in dtPro.Rows)
            {
                Mes tmpProd = new Mes();

                tmpProd.Codigo = Convert.ToInt32(drPro["IdFechaDia"]);
                tmpProd.Nombre = Convert.ToString(drPro["Descripcion"]);


                lstPro.Add(tmpProd);
            }

            return lstPro;
        }
        //HORAS
        public static void InsSemestre(Horas Objeto)
        {
            try
            {
                AccesoDatos.reaOperacion("Insert Into Semestre ( Descripcion) values('" + Objeto.Descripcion + "')");
            }
            catch { }
            
        }
        public static List<Mes> lisHoras()
        {
            List<Mes> lstPro = new List<Mes>();
            DataTable dtPro = new DataTable();

            dtPro = AccesoDatos.reaConsulVista("select IdHora,Descripcion from Horas");

            foreach (DataRow drPro in dtPro.Rows)
            {
                Mes tmpProd = new Mes();

                tmpProd.Codigo = Convert.ToInt32(drPro["IdHora"]);
                tmpProd.Nombre = Convert.ToString(drPro["Descripcion"]);


                lstPro.Add(tmpProd);
            }

            return lstPro;
        }
        public static List<Mes> lisSemestres()
        {
            List<Mes> lstPro = new List<Mes>();
            DataTable dtPro = new DataTable();

            dtPro = AccesoDatos.reaConsulVista("select IdSemestre,Descripcion from Semestre");

            foreach (DataRow drPro in dtPro.Rows)
            {
                Mes tmpProd = new Mes();

                tmpProd.Codigo = Convert.ToInt32(drPro["IdSemestre"]);
                tmpProd.Nombre = Convert.ToString(drPro["Descripcion"]);


                lstPro.Add(tmpProd);
            }

            return lstPro;
        }
        public static Horas EnviarHoras(Int32 codigo)
        {
            Horas Temp = new Horas();
            try
            {
                Temp.IdHoras = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdHora from Horas where IdHora='" + codigo + "'"));
                Temp.Descripcion = Convert.ToString(AccesoDatos.ConsultaDato("select Descripcion from Horas where IdHora='" + codigo + "'"));
                Temp.HoraInicial = Convert.ToDateTime(AccesoDatos.ConsultaDato("select HoraInicial from Horas where IdHora='" + codigo + "'"));
                Temp.HoraFinal = Convert.ToDateTime(AccesoDatos.ConsultaDato("select HoraFinal from Horas where IdHora='" + codigo + "'"));

            }
            catch { }

            return Temp;

        }
        public static Horas EnviarSemestre()
        {
            Horas Temp = new Horas();
            try
            {
                Temp.IdHoras = Convert.ToInt32(AccesoDatos.ConsultaDato("SELECT COUNT(IdSemestre) FROM Semestre"));
                Temp.Descripcion = Convert.ToString(AccesoDatos.ConsultaDato("SELECT Descripcion FROM Semestre where IdSemestre='" + Temp.IdHoras + "'"));

            }
            catch { }

            return Temp;

        }
        public static Horas EnviarSemestre(string codigo)
        {
            Horas Temp = new Horas();
            try
            {
                
                Temp.Descripcion = Convert.ToString(AccesoDatos.ConsultaDato("SELECT Descripcion FROM Semestre where IdSemestre='" + codigo + "'"));

            }
            catch { }

            return Temp;

        }
        public static int CodigoHora(DateTime hora)
        {
            int IdHoras;

            IdHoras = Convert.ToInt32(AccesoDatos.ConsultaDato("select IdHora from Horas where HoraInicial<='" + hora + "' and '" + hora+ "'<=HoraFinal"));
           

           return IdHoras;



        }
        //PROGRAMACION DE CURSOS
        public static int UltimoRegistroProgramacion()
        {
            int cantidad = Convert.ToInt32(AccesoDatos.ConsultaDato("select IDENT_CURRENT('ProgramacionCurso')"));
            return cantidad;
        }
        public static void EliminarRegistroPro(string codigo)
        {
            try
            {
                AccesoDatos.ConsultaDato("delete ProgramacionHorario from ProgramacionCurso where IdProgramacion='" + codigo + "'");
            }
            catch { }
            
        }
        public static void InsProgramacionCursos(ProgramacionHorarios Objeto, string condicion, string curso, string docente)
        {

            if (condicion=="1")
            {
            try
            {
                AccesoDatos.reaOperacion("Insert Into ProgramacionCurso ( IdCurso,IdDoc,FechaInicio,FechaFinal,IdSemestre) values('" + Objeto.Curso + "','" + Objeto.Docente + "','" + Objeto.FechaInicial + "','" + Objeto.FechaFinal + "','" + Objeto.Semestre + "')");


            }
            catch { }
            }
            else if (condicion == "2")
            {

                Objeto.IdProgramacion = UltimoRegistroProgramacion().ToString();

                try
                {
                    AccesoDatos.reaOperacion("Insert Into ProgramacionHorario ( IdFechaDia, IdHora,IdLaboratorio,IdDisponibilidad) values('" + Objeto.Fecha + "','" + Objeto.Hora + "','" + Objeto.Laboratorio + "','" + Objeto.IdProgramacion + "')");
                }
                catch { }

            } if (condicion == "3")
            {
                try
                {
                    Objeto.IdProgramacion = Convert.ToString(AccesoDatos.ConsultaDato("SELECT     ProgramacionCurso.IdDisponibilidad FROM         dbo.ProgramacionCurso  WHERE ProgramacionCurso.IdCurso='" + curso + "'  AND ProgramacionCurso.IdDoc='" + docente + "'AND ProgramacionCurso.FechaFinal>='" + DateTime.Now + "' "));
                }
                catch { }

                try
                {
                    AccesoDatos.reaOperacion("Insert Into ProgramacionHorario ( IdFechaDia, IdHora,IdLaboratorio,IdDisponibilidad) values('" + Objeto.Fecha + "','" + Objeto.Hora + "','" + Objeto.Laboratorio + "','" + Objeto.IdProgramacion + "')");
                }
                catch { }
            }

        }
        public static List<ProgramacionHorarios> lisProgramacion()
        {
            List<ProgramacionHorarios> lstPro = new List<ProgramacionHorarios>();
            DataTable dtPro = new DataTable();

            dtPro = AccesoDatos.reaConsulVista("SELECT     dbo.FechaDia.Descripcion AS DIA, dbo.Horas.Descripcion AS HORA, dbo.Laboratorio.Nombre AS LABORATORIO, dbo.Curso.Nombre AS CURSO, FechaDia.IdFechaDia FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE dbo.ProgramacionCurso.IdDisponibilidad='" + UltimoRegistroProgramacion().ToString() + "' order by IdFechaDia ASC");

            foreach (DataRow drPro in dtPro.Rows)
            {
                ProgramacionHorarios tmpProd = new ProgramacionHorarios();

                tmpProd.Fecha = Convert.ToString(drPro["DIA"]);
                tmpProd.Hora = Convert.ToString(drPro["HORA"]);
                tmpProd.Curso = Convert.ToString(drPro["CURSO"]);

                tmpProd.Laboratorio = Convert.ToString(drPro
["LABORATORIO"]);


               
                
                
                lstPro.Add(tmpProd);
                
            }

            return lstPro;
        }
        public static List<ProgramacionHorarios> lisProgramacion2(string curso,string docente,string semestre)
        {
            List<ProgramacionHorarios> lstPro = new List<ProgramacionHorarios>();
            DataTable dtPro = new DataTable();

            dtPro = AccesoDatos.reaConsulVista("SELECT    dbo.ProgramacionHorario.IdProgramacion, dbo.FechaDia.Descripcion AS DIA, dbo.Horas.Descripcion AS HORA, dbo.Laboratorio.Nombre AS LABORATORIO, dbo.Curso.Nombre AS CURSO, FechaDia.IdFechaDia FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE Curso.IdCurso='" + curso + "'  AND ProgramacionCurso.IdDoc='" + docente + "'  and ProgramacionCurso.IdSemestre='" + semestre + "' and FechaFinal>='"+DateTime.Now+"'order by IdFechaDia ASC");

            foreach (DataRow drPro in dtPro.Rows)
            {
                ProgramacionHorarios tmpProd = new ProgramacionHorarios();
                tmpProd.IdProgramacion = Convert.ToString(drPro["IdProgramacion"]);
                tmpProd.Fecha = Convert.ToString(drPro["DIA"]);
                tmpProd.Hora = Convert.ToString(drPro["HORA"]);
                tmpProd.Curso = Convert.ToString(drPro["CURSO"]);

                tmpProd.Laboratorio = Convert.ToString(drPro["LABORATORIO"]);


                lstPro.Add(tmpProd);
            }

            return lstPro;
        }
        public static int CantidadProgramacionCursos()
        {
            int IdHoras;
          
                IdHoras = Convert.ToInt32(AccesoDatos.ConsultaDato("select COUNT(IdDisponibilidad) from ProgramacionCurso"));
            

            return IdHoras;
          


        }
        public static int CantidadProgramacionHorario()
        {
            int IdHoras;

            IdHoras = Convert.ToInt32(AccesoDatos.ConsultaDato("select IDENT_CURRENT('ProgramacionHorario')"));


            return IdHoras;



        }
        public static ProgramacionHorarios EnviarFechasProgramacion(int codigo )
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();

            try
            {

                Temp.FechaInicial = Convert.ToDateTime(AccesoDatos.ConsultaDato("select FechaInicio from ProgramacionCurso where IdDisponibilidad='" + codigo + "'"));
            }
            catch { }
            try
            {

                Temp.FechaFinal = Convert.ToDateTime(AccesoDatos.ConsultaDato("select FechaFinal from ProgramacionCurso where IdDisponibilidad='" + codigo + "'"));
            }
            catch { }

            try
            {

                Temp.Curso = Convert.ToString(AccesoDatos.ConsultaDato("select IdCurso from ProgramacionCurso where IdDisponibilidad='" + codigo + "'"));
            }
            catch { }

                try
            {

                Temp.Semestre = Convert.ToString(AccesoDatos.ConsultaDato("select IdSemestre from ProgramacionCurso where IdDisponibilidad='" + codigo + "'"));
            }
            catch { }



            return Temp;
        }

        public static ProgramacionHorarios EnviarProgramacionCurso(string curso, string condicion,string docente)
        {

            ProgramacionHorarios Temp = new ProgramacionHorarios();
            

            if(condicion=="")
            {
            try
            {
                  Temp.Bandera = false;
                for (int i = 1; i <= CantidadProgramacionCursos();i++ )
                {
                    Temp.Docente = Convert.ToString(AccesoDatos.ConsultaDato("select IdDoc from ProgramacionCurso where IdDisponibilidad='" + i + "'"));
                    Temp.Curso = Convert.ToString(AccesoDatos.ConsultaDato("select IdCurso from ProgramacionCurso where IdDisponibilidad='" + i + "'"));
                    Temp.FechaFinal = Convert.ToDateTime(AccesoDatos.ConsultaDato("select FechaFinal from ProgramacionCurso where IdDisponibilidad='" + i + "'"));



                    if (Temp.Docente == docente && Temp.Curso == curso && Temp.FechaFinal>DateTime.Now)
                    {
                     
                            Temp.Bandera = true;
                            return Temp;


                    }

                }

            }
            catch { }

            return Temp;
            }else{
            
            try
            {

                 Temp.Bandera = false;
                 for (int i = 1; i <= CantidadProgramacionCursos(); i++)
                 {
                     Temp.Curso = Convert.ToString(AccesoDatos.ConsultaDato("select IdCurso from ProgramacionCurso where IdDisponibilidad='" + i + "'"));

                     if (Temp.Curso == curso)
                     {
                         Temp.Bandera = true;
                         return Temp;
                     }
                    
                 }

            }
            catch { }

            return Temp;
            
            
            }

        }
        public static ProgramacionHorarios EnviarProgramacion(string dia,string hora, string laborat, string semestre)
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();
            
                try
                {

                    Temp.Fecha = Convert.ToString(AccesoDatos.ConsultaDato("SELECT   dbo.FechaDia.Descripcion AS DIA FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='"+DateTime.Now+"' "));

                    Temp.Hora = Convert.ToString(AccesoDatos.ConsultaDato("SELECT   dbo.Horas.Descripcion AS HORA FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='" + DateTime.Now + "' "));

                    Temp.Laboratorio = Convert.ToString(AccesoDatos.ConsultaDato("SELECT   dbo.Laboratorio.Nombre AS LABORATORIO FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='" + DateTime.Now + "'"));

                    Temp.IdProgramacion = Convert.ToString(AccesoDatos.ConsultaDato("SELECT   dbo.ProgramacionCurso.IdDisponibilidad AS LABORATORIO FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='" + DateTime.Now + "'"));

                    Temp.Curso = Convert.ToString(AccesoDatos.ConsultaDato("SELECT   dbo.Curso.Nombre AS CURSO FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='" + DateTime.Now + "'"));

                    try
                    {
                        Temp.IdProgramacion = Convert.ToString(AccesoDatos.ConsultaDato("SELECT   dbo.ProgramacionCurso.IdDisponibilidad FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='" + DateTime.Now + "'"));
                    }
                    catch { }

                    try
                    {
                        Temp.FechaInicial = Convert.ToDateTime(AccesoDatos.ConsultaDato("SELECT   dbo.ProgramacionCurso.FechaInicio FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='" + DateTime.Now + "'"));
                    }
                    catch { }
                    try
                    {
                        Temp.FechaFinal = Convert.ToDateTime(AccesoDatos.ConsultaDato("SELECT   dbo.ProgramacionCurso.FechaFinal FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='" + DateTime.Now + "'"));
                    }
                    catch { }
                    try
                    {
                        Temp.Docente = Convert.ToString(AccesoDatos.ConsultaDato("SELECT   dbo.ProgramacionCurso.IdDoc FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' and ProgramacionCurso.IdSemestre='" + semestre + "' and  FechaFinal>='" + DateTime.Now + "'"));
                    }
                    catch { }
                    try
                    {

                        Temp.Docente = EnivarDocente(Temp.Docente, "iddoc").Nombre + " " + EnivarDocente(Temp.Docente, "iddoc").ApellidoPaterno + " " + EnivarDocente(Temp.Docente, "iddoc").ApellidoMaterno;
                    }
                    catch { }

                }
                catch { }

                return Temp;
        }
        public static ProgramacionHorarios EnviarProgramacionDocente(string dia, string hora, string laborat)
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();
            try
            {
                Temp.Docente = Convert.ToString(AccesoDatos.ConsultaDato("SELECT   dbo.ProgramacionCurso.IdDoc FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.Curso ON dbo.ProgramacionCurso.IdCurso = dbo.Curso.IdCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN                       dbo.FechaDia ON dbo.ProgramacionHorario.IdFechaDia = dbo.FechaDia.IdFechaDia INNER JOIN                       dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora INNER JOIN                       dbo.Laboratorio ON dbo.ProgramacionHorario.IdLaboratorio = dbo.Laboratorio.IdLaboratorio WHERE ProgramacionHorario.IdFechaDia='" + dia + "'  AND ProgramacionHorario.IdHora='" + hora + "' AND ProgramacionHorario.IdLaboratorio='" + laborat + "' "));
            }
            catch { }

            return Temp;
        }
        public static ProgramacionHorarios EnviarHorarios(string comparacion, string condi,string semestre)
        {
            string prueba;
            ProgramacionHorarios Temp = new ProgramacionHorarios();
           
            try
            {
                 Temp.Bandera = false;
                 for (int i = 1; i <= CantidadProgramacionHorario(); i++)
                 {
                     Temp.Hora = Convert.ToString(AccesoDatos.ConsultaDato("select IdHora FROM         dbo.ProgramacionCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad where ProgramacionCurso.FechaFinal>='"+DateTime.Now+"' and ProgramacionHorario.IdProgramacion='"+i+"' and ProgramacionCurso.IdSemestre='"+semestre+"'"));

                     Temp.Fecha = Convert.ToString(AccesoDatos.ConsultaDato("select IdFechaDia from dbo.ProgramacionCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad where ProgramacionCurso.FechaFinal>='" + DateTime.Now + "' and ProgramacionHorario.IdProgramacion='" + i + "' and ProgramacionCurso.IdSemestre='" + semestre + "'"));

                     try
                     {
                         Temp.Laboratorio = Convert.ToString(AccesoDatos.ConsultaDato("select IdLaboratorio from dbo.ProgramacionCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad where ProgramacionCurso.FechaFinal>='" + DateTime.Now + "' and ProgramacionHorario.IdProgramacion='" + i + "' and ProgramacionCurso.IdSemestre='" + semestre + "'"));
                     }
                     catch { }
                     try
                     {
                         Temp.Laboratorio = Convert.ToString(AccesoDatos.ConsultaDato("select IdLaboratorio from dbo.ProgramacionCurso INNER JOIN                       dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad where ProgramacionCurso.FechaFinal>='" + DateTime.Now + "' and ProgramacionHorario.IdProgramacion='" + i + "' and ProgramacionCurso.IdSemestre='" + semestre + "'"));
                     }
                     catch { }
                     prueba = Temp.Fecha + Temp.Hora + Temp.Laboratorio;


                     if (prueba == comparacion )
                     {
                         if (EnviarProgramacion(Temp.Fecha, Temp.Hora, Temp.Laboratorio, semestre).FechaFinal > DateTime.Now)
                         {
                             Temp.Bandera = true;
                             return Temp;
                         }

                     }

                   

                   
                 }
                } catch { }

            return Temp;
        
            
            }

        
        //DISPONIBILIDAD
        public static ProgramacionHorarios EnviarDisponibilidad(int laboratorio, int programacion, string cond,string semestre)
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();
           if(cond=="fecha")
           {
                try
                {

                    Temp.Fecha = Convert.ToString(AccesoDatos.ConsultaDato("SELECT     dbo.ProgramacionHorario.IdFechaDia FROM       dbo.ProgramacionCurso INNER JOIN dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad where dbo.ProgramacionHorario.IdLaboratorio='" + laboratorio + "' and dbo.ProgramacionHorario.IdProgramacion='" + programacion + "'  and ProgramacionCurso.IdSemestre='" + semestre + "' "));

                    

                }
                catch { }

                return Temp;


           }else if(cond=="hora"){
               try{

                   Temp.Hora = Convert.ToString(AccesoDatos.ConsultaDato(" SELECT dbo.ProgramacionHorario.IdHora FROM       dbo.ProgramacionCurso INNER JOIN dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad where dbo.ProgramacionHorario.IdLaboratorio='" + laboratorio + "' and dbo.ProgramacionHorario.IdProgramacion='" + programacion + "' and ProgramacionCurso.IdSemestre='" + semestre + "'"));
               }catch{}
           
           return Temp;
           }else{


               try
               {

                   Temp.Curso = Convert.ToString(AccesoDatos.ConsultaDato(" SELECT dbo.ProgramacionCurso.IdCurso FROM       dbo.ProgramacionCurso INNER JOIN dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad where dbo.ProgramacionHorario.IdLaboratorio='" + laboratorio + "' and dbo.ProgramacionHorario.IdProgramacion='" + programacion + "' and dbo.ProgramacionCurso.FechaFinal>='" + DateTime.Now.ToShortDateString() + "' and ProgramacionCurso.IdSemestre='" + semestre + "'"));

                   Temp.Curso = EnviarCurso(Temp.Curso,"id").Nombre;
               }
               catch { }
               try
               {

                   Temp.Docente = Convert.ToString(AccesoDatos.ConsultaDato(" SELECT dbo.ProgramacionCurso.IdDoc FROM       dbo.ProgramacionCurso INNER JOIN dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad where dbo.ProgramacionHorario.IdLaboratorio='" + laboratorio + "' and dbo.ProgramacionHorario.IdProgramacion='" + programacion + "'  and dbo.ProgramacionCurso.FechaFinal>='" + DateTime.Now.ToShortDateString() + "'  and ProgramacionCurso.IdSemestre='" + semestre + "'"));

                   Temp.Docente =EnivarDocente(Temp.Docente, "id").Nombre;
               }
               catch { }
                  

             
               return Temp;
           
           
           
           
           }


            }
        public static int VerificarDisponibilidad(int hora,int dia,string labora,int semestre)
        {
           
            int  Temp ;

            Temp = Convert.ToInt32(AccesoDatos.ConsultaDato("SELECT  dbo.Personal.IdDoc FROM  dbo.ProgramacionCurso INNER JOIN dbo.ProgramacionHorario ON dbo.ProgramacionCurso.IdDisponibilidad = dbo.ProgramacionHorario.IdDisponibilidad INNER JOIN dbo.Personal ON dbo.ProgramacionCurso.IdDoc = dbo.Personal.IdDoc INNER JOIN dbo.Horas ON dbo.ProgramacionHorario.IdHora = dbo.Horas.IdHora where ProgramacionHorario.IdFechaDia='" + dia + "' and Horas.IdHora='" + hora + "' and ProgramacionHorario.IdLaboratorio='" + labora + "' and ProgramacionCurso.IdSemestre='" + semestre + "'"));
              
            return Temp;

         

        }
        

        


    }
}



