using Services;
using Moq;
using NUnit.Framework;
using api.Controllers;
using System.Linq;
using System.Collections.Generic;

namespace test
{
    public class Tests
    {
        private ControladorCarrito controller;
        private Mock<IServicioPago> ServicioPagoMock;
        private Mock<IServicioCarrito> ServicioCarritoMock;

        private Mock<IServicioEnvio> ServicioEnvioMock;
        private Mock<ITarjeta> tarjetaMock;
        private Mock<IDireccion> direccionMock;
        private List<ItemsTarjeta> items;

        [SetUp]
        public void Setup()
        {

            ServicioCarritoMock = new Mock<IServicioCarrito>();
            ServicioPagoMock = new Mock<IServicioPago>();
            ServicioEnvioMock = new Mock<IServicioEnvio>();

            // arrange
            tarjetaMock = new Mock<ITarjeta>();
            direccionMock = new Mock<IDireccion>();

            // 
            var itemsTarjetaMock = new Mock<ItemsTarjeta>();
            itemsTarjetaMock.Setup(item => item.Price).Returns(10);

            items = new List<ItemsTarjeta>()
            {
                itemsTarjetaMock.Object
            };

            ServicioCarritoMock.Setup(c => c.Items()).Returns(items.AsEnumerable());

            controller = new ControladorCarrito(ServicioCarritoMock.Object, ServicioPagoMock.Object, ServicioEnvioMock.Object);
        }

        [Test]
        public void testDebeAceptarTarjeta()
        {
            ServicioPagoMock.Setup(p => p.Charge(It.IsAny<double>(), tarjetaMock.Object)).Returns(true);

            // act
            var result = controller.CheckOut(tarjetaMock.Object, direccionMock.Object);

            // assert
            // myInterfaceMock.Verify((m => m.DoesSomething()), Times.Once());
            ServicioEnvioMock.Verify(s => s.Ship(direccionMock.Object, items.AsEnumerable()), Times.Once());

            Assert.AreEqual("Tarjeta aceptada", result);
        }

        [Test]
        public void testNoDebeAceptarTarjeta()
        {
            ServicioPagoMock.Setup(p => p.Charge(It.IsAny<double>(), tarjetaMock.Object)).Returns(false);

            // act
            var result = controller.CheckOut(tarjetaMock.Object, direccionMock.Object);

            // assert
            ServicioEnvioMock.Verify(s => s.Ship(direccionMock.Object, items.AsEnumerable()), Times.Never());
            Assert.AreEqual("Tarjeta NO aceptada", result);
        }
    }
}