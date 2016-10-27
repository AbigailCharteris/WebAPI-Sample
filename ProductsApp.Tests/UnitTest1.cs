using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web;


namespace ProductsApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Mock<ProductsApp.Controllers.ProductsController> prodController;
        [TestInitialize]
        public void Init()
        {
            prodController = new Mock<ProductsApp.Controllers.ProductsController>();
            
        }

        [TestMethod]
        public void GetProductByIdTest()
        {

            //arrange
            prodController.Setup(e => e.GetProduct(It.IsAny<int>)).Returns(It.IsAny<string>);

            //act
            var result = prodController.Object.GetProduct(1);

            //Assert
            prodController.Verify(e => e.GetProduct(It.IsAny<int>), Times.AtLeastOnce);

        }
    }
}
