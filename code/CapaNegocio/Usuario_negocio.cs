using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto.Generators;
using CapaNegocio.Seguridad;

namespace CapaNegocio
{
    public class Usuario_negocio
    {
        private Usuario_Datos objUser_datos = new Usuario_Datos();

        public List<Usuario> Listar()//mostrarUsuarios -> mostrarEmpleados
        {
            return objUser_datos.Listar();
        }

        public Usuario AutenticarUsuario(string username, string password, out string mensaje)
        {
            mensaje = "";

            try
            {
                var usuario = objUser_datos.ObtenerUsuarioLogin(username);

                if (usuario == null)
                {
                    mensaje = "Usuario o contraseña inválidos.";
                    return null;
                }

                if (usuario.baja_user)
                {
                    mensaje = "El usuario ha sido dado de baja.";
                    return null;
                }

                if (usuario.objRoles == null || usuario.objRoles.id_rol == 0)
                {
                    mensaje = "El usuario no tiene permisos asignados.";
                    return null;
                }

                bool isAuthenticated = false;

                if (!string.IsNullOrWhiteSpace(usuario.pass))
                {
                    isAuthenticated = PasswordHasher.VerifyPassword(password, usuario.pass);
                    //Para pruebas comentar el PasswordHasher.VerifyPassword y utilizar la siguiente en su lugar
                    //isAuthenticated = password == usuario.pass;
                    //
                    //
                    //usuarios con pass hasheada:
                    //admin - admin123
                    //superadmin - 123456
                    //analista - 123456
                    //juanP - pass123 /vendedor
                    //jcpsnmsnk - 123456
                    //
                }

                if (!isAuthenticated)
                {
                    mensaje = "Usuario o contraseña inválidos.";
                    return null;
                }

                return usuario;
            }
            catch (SqlException ex)
            {
                mensaje = "No se pudo conectar con el servidor de base de datos.";
                return null;
            }
            catch (InvalidOperationException ex)
            {
                mensaje = "Error al intentar acceder a los datos del usuario.";
                return null;
            }
            catch (Exception ex)
            {
                mensaje = "Se produjo un error inesperado: " + ex.Message;
                return null;
            }
        }

        public int Registrar(Usuario obj, out string Mensaje)//crearUsuario
        {
            Mensaje = string.Empty;

            if (obj.nombre == "")
            {
                Mensaje += "Debe ingresar un nombre\n";
            }

            if (obj.apellido == "")
            {
                Mensaje += "Debe ingresar un apellido\n";
            }


            if (obj.pass == "")
            {
                Mensaje += "Debe ingresar una contraseña\n";
            }

            if (obj.username == "")
            {
                Mensaje += "Debe ingresar un nombre de usuario\n";
            }

            if (string.IsNullOrWhiteSpace(obj.telefono_user))
            {
                Mensaje += "El TELEFONO del usuario es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(obj.direccion_user))
            {
                Mensaje += "La DIRECCIÓN del usuario es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(obj.localidad_user))
            {
                Mensaje += "La LOCALIDAD del usuario es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(obj.provincia_user))
            {
                Mensaje += "La PROVINCIA del usuario es obligatorio.\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objUser_datos.Registrar(obj, out Mensaje);
            }
            

        }

        /*public List<Usuario> BuscarUsuarios(Usuario filtros)
        {
            return objUser_datos.BuscarUsuarios(filtros);
        }*/

        public List<Usuario> BuscarUsuariosGeneral(string filtros)
        {
            return objUser_datos.BuscarUsuariosGeneral(filtros);
        }
        
        public bool Editar(Usuario obj, out string Mensaje)//editarUsuario
        {
            Mensaje = string.Empty;

            if (obj.nombre == "")
            {
                Mensaje += "Debe ingresar un nombre\n";
            }

            if (obj.apellido == "")
            {
                Mensaje += "Debe ingresar un apellido\n";
            }

            if (obj.pass == "")
            {
                Mensaje += "Debe ingresar una contraseña\n";
            }

            if (obj.username == "")
            {
                Mensaje += "Debe ingresar un nombre de usuario\n";
            }

            if (string.IsNullOrWhiteSpace(obj.telefono_user))
            {
                Mensaje += "El TELEFONO del usuario es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(obj.direccion_user))
            {
                Mensaje += "La DIRECCIÓN del usuario es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(obj.localidad_user))
            {
                Mensaje += "La LOCALIDAD del usuario es obligatorio.\n";
            }
            if (string.IsNullOrWhiteSpace(obj.provincia_user))
            {
                Mensaje += "La PROVINCIA del usuario es obligatorio.\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objUser_datos.Editar(obj, out Mensaje);
            }
        }
    }
}
