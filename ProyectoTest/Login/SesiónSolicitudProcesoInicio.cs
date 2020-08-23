using System;

namespace Login
{
    public class SesiónSolicitudProcesoInicio
    {
        //la nueva solicitud del usuario en el sistema es privado 
        //por eso tiene la clase privada    
        private readonly SesionSolicitudForm _sesionSolicitudForm;
        //Iniciamos la solicitud de inicio de sesión
        public SesiónSolicitudProcesoInicio(SesionSolicitudForm sesionSolicitudForm)
        {
            _sesionSolicitudForm = sesionSolicitudForm;
        }
        // Si la sesion es nula envia la execpion de falta usuario o falta contraseña
        
        public SesionRespuestaInicio Sesion(SesionSolicitudInicio solicitud)
        {
            if (solicitud is null)
            {
                throw new ArgumentNullException(nameof(solicitud));
            }
            //si en la sesion se ingresa correctamente crea un nuevo inicio de sesión
            _sesionSolicitudForm.Save(Create<Sesion>(solicitud));

            return Create<SesionRespuestaInicio>(solicitud);
        }
        //inicia la sesion de la solicitud del usuario con los parametros del usuario
        //contraseña y password
        private static T Create<T>(SesionSolicitudInicio solicitud) where T : SesionUsuarios, new ()
        {
            return new T
            {
                Usuario = solicitud.Usuario,
                Password = solicitud.Password,
                TipoUsuario = solicitud.TipoUsuario
                
            };
        }
    }
}