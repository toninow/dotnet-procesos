using Moq;
using System;
using Xunit;

namespace Login.Tests
{
    
    // declaramos la Clase pública para inicio de Sesión
    public class SesionSolicitudProcesoInicioTests
    {
        //deben ser solo de lectura y privadas ya que es una sesión por usuario 
        private readonly SesionSolicitudInicio _solicitud;
        private readonly Mock<SesionSolicitudForm> _sesionSolicitudFormMock;
        private readonly SesiónSolicitudProcesoInicio _proceso;

        //El usuario Ingresa sus datos en el sistema
        public SesionSolicitudProcesoInicioTests()
        {
            //arange
            _solicitud = new SesionSolicitudInicio
            {
                Usuario = "Antonio",
                Password = "12345678",
                TipoUsuario = "administrador"
            };
            _sesionSolicitudFormMock = new Mock<SesionSolicitudForm>();
            _proceso = new SesiónSolicitudProcesoInicio(_sesionSolicitudFormMock.Object);
        }

        [Fact]

        //verificamos que los datos que ingreso el usuario 
        //son correctos entonces ingresaría al sistema
        public void ComparaValoresIngresadosConAlmacenados()
        {
            // Act
            SesionRespuestaInicio respuesta = _proceso.Sesion(_solicitud);

            // Assert
            Assert.NotNull(respuesta);
            Assert.Equal(_solicitud.Usuario, respuesta.Usuario);
            Assert.Equal(_solicitud.Password, respuesta.Password);
            Assert.Equal(_solicitud.TipoUsuario, respuesta.TipoUsuario);
        }

        [Fact]

        //Si se envia los datos vacios envia una exepcion de datos //DEBE INGRESARLOS
        public void EnviaExcepcionCuandoLaSolicitudEsNula()
        {
            // Act 
            var exception = Assert.Throws<ArgumentNullException>(() => _proceso.Sesion(null));

            // Assert
            //envia los datos faltantes en una excepcion
            Assert.Equal("solicitud", exception.ParamName);
        }

    }
}
