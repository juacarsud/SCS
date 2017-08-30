using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControlHorario.Negocio;
using SistemaControlHorario.Entidades;
using SistemaControlHorario.Datos;




namespace SistemaControlHorario.Negocio
{
    public class ControlEntidades
    {
        //LABORATORIO
        public static void Registrar(Laboratorio objeto)
        {
            if (Convert.ToString(objeto.IdLaboratorio) != "")
            {
                Consultas.InsLaboratorio(objeto);
            }
            else
                throw new Exception("El código del Producto esta vacío");
        }
        public static void Editar(Laboratorio objeto)
        {
            if (Convert.ToString(objeto.IdLaboratorio) != "")
            {
                Consultas.ModLaboratorio(objeto);
            }
            else
                throw new Exception("El código del Producto esta vacio");
        }
        public static List<Laboratorio> VerLaboratorio()
        {

            List<Laboratorio> tmpLista;
            if (Consultas.listaLaboratorio().Count != 0)
            {
                tmpLista = Consultas.listaLaboratorio();

            }
            else
            {
                return null;
            }

            return tmpLista;
        }
        public static bool BuscarCodigoLaboratorio(string codigo)
        {
            bool bandera = false;
          return  bandera =Consultas.BuscarCodigoLaboratorio (codigo);

             
        }
        public static List<Laboratorio> VerGridFiltroLaboratorio(List<Laboratorio> tmpLaboratorio, String CadFiltro)
        {

            var Consulta = from Labo in tmpLaboratorio
                           where (Labo.Codigo.StartsWith(CadFiltro.Trim()) || Labo.Nombre.StartsWith(CadFiltro.Trim()) || Labo.Ubicacion.StartsWith(CadFiltro.Trim()))
                           select Labo;
            tmpLaboratorio = Consulta.ToList();
            return tmpLaboratorio;
        }
        public static Laboratorio EnviarLaboratorio(int codigo, string fecha)
        {
            Laboratorio Temp = new Laboratorio();
            Temp = Consultas.EnviarLaboratorio(codigo, fecha);

            return Temp;

        }
        public static Laboratorio EnviarLaboratorio(int codigo)
        {
            Laboratorio Temp = new Laboratorio();
            Temp = Consultas.EnviarLaboratorio(codigo);

            return Temp;

        }
        //DOCENTE
        public static List<Docente> VerGridFiltro(List<Docente> tmpDocente, String CadFiltro)
        {

            var Consulta = from Doce in tmpDocente
                           where (Doce.Dni.StartsWith(CadFiltro.Trim()) || Doce.Nombre.StartsWith(CadFiltro.Trim()) || Doce.ApellidoPaterno.StartsWith(CadFiltro.Trim()) || Doce.ApellidoMaterno.StartsWith(CadFiltro.Trim()))
                           select Doce;
            tmpDocente = Consulta.ToList();
            return tmpDocente;
        }
        public static Docente EnviarDocente(string codigo,string condi)
        {
            Docente Temp = new Docente();
            try
            {
                Temp = Consultas.EnivarDocente(codigo, condi);
            }
            catch { }

            return Temp;

        }
        public static void Registrar(Docente objeto)
        {
            if (Convert.ToString(objeto.IdDocente) != "")
            {
                Consultas.InsDocente(objeto);
            }
            else
                throw new Exception("El código del Producto esta vacío");
        }
        public static void Editar(Docente objeto)
        {
            if (Convert.ToString(objeto.IdDocente) != "")
            {
                Consultas.ModDocente(objeto);
            }
            else
                throw new Exception("El código del Producto esta vacio");
        }
        public static void ModificarContraseña(Docente objeto)
        {
            if (Convert.ToString(objeto.IdDocente) != "")
            {
                Consultas.ModContraseña(objeto);
            }
            else
                throw new Exception("El código del Producto esta vacio");
        }
        public static List<Docente> VerDocente(string cond)
        {

            List<Docente> tmpLista;
            if (Consultas.listaDocente(cond).Count != 0)
            {
                tmpLista = Consultas.listaDocente(cond);

            }
            else
            {
                return null;
            }

            return tmpLista;
        }
        //ALUMNO
        public static void Modifica(Alumno ObjUsuario)
        {
            if (ObjUsuario.Dni.ToString()!="")
            {
                Consultas.ModAlumno(ObjUsuario);
            }
            else
                throw new Exception("El Nombre del Usuario esta vacío");
        }
        public static Alumno EnviarAlumno(string codigo, string condicion)
        {
            Alumno Temp = new Alumno();

            Temp = Consultas.EnviarAlumno(codigo,condicion);

            return Temp;

        }
        public static List<Alumno> VerGridFiltroAlumno(List<Alumno> tmpPro, String CadFiltro)
        {
            try
            {
                var Consulta = from Prod in tmpPro
                               where (Prod.Nombre.StartsWith(CadFiltro) || Prod.Paterno.StartsWith(CadFiltro) || Prod.Materno.StartsWith(CadFiltro))
                               select Prod;
                tmpPro = Consulta.ToList();
            }
            catch { }
            return tmpPro;
        }
        public static void Registrar(Alumno ObjUsuario)
        {

            Consultas.InsAlumno(ObjUsuario);
            
        }
        public static List<Alumno> VerAlumno(string cond)
        {
            List<Alumno> tmpLista;
            if (Consultas.lisAlumno(cond).Count != 0)
            {
                tmpLista = Consultas.lisAlumno(cond);
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        public static List<Alumno> VerGridFiltroAlumnos(List<Alumno> tmpPro, String CadFiltro)
        {
            var Consulta = from Prod in tmpPro
                           where (Prod.Nombre.StartsWith(CadFiltro.Trim()) || Prod.Materno.StartsWith(CadFiltro.Trim()) || Prod.Paterno.StartsWith(CadFiltro.Trim()) || Prod.Dni.ToString().StartsWith(CadFiltro.Trim()))
                           select Prod;
            tmpPro = Consulta.ToList();
            return tmpPro;
        }
        //ROLES
        public static List<Rol> VerRol(String condicion)
        {
            List<Rol> tmpLista;
            if (Consultas.lisRol(condicion).Count != 0)
            {
                tmpLista = Consultas.lisRol(condicion);
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        //CURSOS
        public static int CantCursos()
        {
            int cant;
            cant = Consultas.CantCursos();

            return cant;
        }
        public static List<Curso> VerCursos(string COND,string semestre)
        {
            List<Curso> tmpLista;
            if (Consultas.listCursos(COND, semestre).Count != 0)
            {
                tmpLista = Consultas.listCursos(COND, semestre);
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        public static Curso EnviarCurso(string codigo,string condi)
        {
            Curso Temp = new Curso();

            Temp = Consultas.EnviarCurso(codigo,condi);

            return Temp;

        }
        public static void Modifica(Curso ObjUsuario,string cond)
        {
            if (ObjUsuario.Codigo != "")
            {
   Consultas.ModCursos(ObjUsuario,cond);
            }
            else
                throw new Exception("El Nombre del Usuario esta vacío");
        }
        public static void Registrar(Curso ObjUsuario)
        {

            Consultas.InsCurso(ObjUsuario);

        }
        public static List<Curso> VerGridFiltroAlumnos(List<Curso> tmpPro, String CadFiltro)
        {
            var Consulta = from Prod in tmpPro
                           where (Prod.Nombre.StartsWith(CadFiltro.Trim()))
                           select Prod;
            tmpPro = Consulta.ToList();
            return tmpPro;
        }
        //HORAS
        public static void Registrar(Horas ObjUsuario)
        {
            Consultas.InsSemestre(ObjUsuario);
        }
        public static Horas EnviarHoras(Int32 codigo)
        {
            Horas Temp = new Horas();
            Temp = Consultas.EnviarHoras(codigo);

            return Temp;

        }
        public static Horas EnviarSemestre()
        {
            Horas Temp = new Horas();
            Temp = Consultas.EnviarSemestre();

            return Temp;

        }
        public static Horas EnviarSemestre(string codigo)
        {
            Horas Temp = new Horas();
            Temp = Consultas.EnviarSemestre(codigo);

            return Temp;

        }
        public static int EnviarCodigoHora(DateTime codigo)
        {
            int Temp;
            
            Temp = Consultas.CodigoHora(codigo);

            return Temp;
        }
        public static List<Mes> VerHoras()
        {
            List<Mes> tmpLista;
            if (Consultas.lisHoras().Count != 0)
            {
                tmpLista = Consultas.lisHoras();
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        public static List<Mes> VerSemestre()
        {
            List<Mes> tmpLista;
            if (Consultas.lisSemestres().Count != 0)
            {
                tmpLista = Consultas.lisSemestres();
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        //ASISTENCIA
        public static Asistencia EnviarAsistencia(string idasistencia)
        {
            Asistencia Temp = new Asistencia();
            Temp = Consultas.EnviarAsistencia(idasistencia);

            return Temp;

        }
        public static int EnviarTardanza(int docente)
        {
            int Temp = 0;
            Temp = Consultas.EnviarTardanza(docente);

            return Temp;

        }
        public static void Registrar(Asistencia ObjUsuario, int codigo)
        {
            Consultas.InsAsistencia(ObjUsuario,codigo);
        }
        public static void ModificaAsistencia(Asistencia ObjUsuario)
        {
            if (ObjUsuario.IdAsistencia.ToString() != "")
            {
                Consultas.ModAsistencia(ObjUsuario);
            }
            else
                throw new Exception("El Nombre del Usuario esta vacío");
        }
        public static Asistencia EnviarHorasPersonal(string  contraseña,DateTime fecha)
        {
            Asistencia Temp = new Asistencia();
            Temp = Consultas.EnviarHoraPersonal(contraseña,fecha);

            return Temp;

        }
        public static List<VistaAsistencia> VerAsistencia(int codigo)
        {

            List<VistaAsistencia> tmpLista;
            if (Consultas.listaLaboratorio().Count != 0)
            {
                tmpLista = Consultas.lisAsistencia(codigo);

            }
            else
            {
                return null;
            }

            return tmpLista;
        }
        //INSCRIPCION
        public static void RegistrarInscripcion(Inscripcion objeto)
        {
            if (Convert.ToString(objeto.IdInscripcion) != "")
            {
                Consultas.InsInscripcion(objeto);
            }
            else
                throw new Exception("El código del Producto esta vacío");
        }
        public static void RegistrarInscripcionPagos(Inscripcion objeto)
        {
            if (Convert.ToString(objeto.IdInscripcion) != "")
            {
                Consultas.InsInscripcionPagos(objeto);
            }
            else
                throw new Exception("El código del Producto esta vacío");
        }
        public static void EditarInscripcion(Inscripcion objeto)
        {
            if (Convert.ToString(objeto.IdInscripcion) != "")
            {
                Consultas.ModInscripcion(objeto);
            }
            else
                throw new Exception("El código del Producto esta vacio");
        }
        public static List<Inscripcion> VerInscripcion()
        {

            List<Inscripcion> tmpLista;
            if (Consultas.listaLaboratorio().Count != 0)
            {
                tmpLista = Consultas.listaInscripcion();

            }
            else
            {
                return null;
            }

            return tmpLista;
        }
        public static List<Inscripcion> VerGridFiltroInscripcion(List<Inscripcion> tmpLaboratorio, String CadFiltro)
        {

            var Consulta = from Labo in tmpLaboratorio
                           where (Labo.NombreAlumno.StartsWith(CadFiltro.Trim()) || Labo.CodigoCurso.StartsWith(CadFiltro.Trim()))
                           select Labo;
            tmpLaboratorio = Consulta.ToList();
            return tmpLaboratorio;
        }
        public static Inscripcion EnviarInscripcion(string codigo)
        {
            Inscripcion Temp = new Inscripcion();
            Temp = Consultas.EnviarInscripcion(codigo);

            return Temp;

        }
        public static Inscripcion EnviarInscripcionAlumno(string alumno, string curso, string semestre, string docente)
        {
            Inscripcion Temp = new Inscripcion();
            Temp = Consultas.EnviarInscripcionAlumno(alumno, curso,  semestre,docente);

            return Temp;

        }
        //CONTROLPAGOS
        public static List<VerPagos> VerPagos(String condicion)
        {
            List<VerPagos> tmpLista;
            if (Consultas.lisRol(condicion).Count != 0)
            {
                tmpLista = Consultas.listPagos(condicion);
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        //MES
        public static List<Mes> VerMes()
        {
            List<Mes> tmpLista;
            if (Consultas.lisMes().Count != 0)
            {
                tmpLista = Consultas.lisMes();
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        //DIAS
        public static List<Mes> VerDias()
        {
            List<Mes> tmpLista;
            if (Consultas.lisDias().Count != 0)
            {
                tmpLista = Consultas.lisDias();
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        //PROGRAMACION 
        public static int UltimoRegistroProgrmacion()
        {

            return Consultas.UltimoRegistroProgramacion();

        }
        public static void EiminarRegistroProgramacion(string codigo)
        {

            Consultas.EliminarRegistroPro(codigo);

        }
        public static void RegistrarProgramacion(ProgramacionHorarios objeto, string Condicion, string curso, string docente)
        {
            if (Convert.ToString(objeto) != "")
            {
                Consultas.InsProgramacionCursos(objeto, Condicion, curso, docente);
            }
            else
                throw new Exception("El código del Producto esta vacío");
        }
        public static List<ProgramacionHorarios> VerProgramacion()
        {
            List<ProgramacionHorarios> tmpLista;
            if (Consultas.lisProgramacion().Count != 0)
            {
                tmpLista = Consultas.lisProgramacion();
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        public static List<ProgramacionHorarios> VerProgramacion2(string curso, string docente,string semestre)
        {
            List<ProgramacionHorarios> tmpLista;
            if (Consultas.lisProgramacion2(curso, docente, semestre).Count != 0)
            {
                tmpLista = Consultas.lisProgramacion2(curso, docente, semestre);
            }
            else
                throw new Exception("El código del Usuario esta vacío");
            return tmpLista;
        }
        public static ProgramacionHorarios EnviarProgramacionCurso(string curso, string cond, string doce)
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();
            Temp = Consultas.EnviarProgramacionCurso(curso, cond,doce);

            return Temp;

        }
        //public static ProgramacionHorarios EnviarInsripcionAlumno(string alumno, string curso, string semestre,string docente)
        //{
        //    ProgramacionHorarios Temp = new ProgramacionHorarios();
        //    Temp = Consultas.EnviarInsripcionAlumno( alumno,  curso,  semestre, docente);

        //    return Temp;

        //}
        public static ProgramacionHorarios EnviarProgramacion(string dia, string hora, string laborat, string semestre)
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();
            Temp = Consultas.EnviarProgramacion( dia, hora,  laborat,semestre);

            return Temp;

        }

        public static ProgramacionHorarios EnviarProgramacionDocente(string dia, string hora, string laborat)
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();
            Temp = Consultas.EnviarProgramacionDocente(dia, hora, laborat);

            return Temp;

        }
        public static ProgramacionHorarios EnviarHorarios(string compara, string cond,string semestre)
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();
            Temp = Consultas.EnviarHorarios(compara, cond, semestre);

            return Temp;

        }
        //DISPONIBILIDAD
        public static ProgramacionHorarios EnviarDisponibilidad(int laboratorio, int programacion, string cond,string semestre)
        {
            ProgramacionHorarios Temp = new ProgramacionHorarios();
            Temp = Consultas.EnviarDisponibilidad(laboratorio, programacion, cond, semestre);

            return Temp;

        }
        public static int VerificarDiponibilidad(int hora, int dia,string labora,int semestre)
        {
            int Temp ;
           
                Temp = Consultas.VerificarDisponibilidad(hora, dia,labora,semestre);
           

            return Temp;
           

        }


    }
}

