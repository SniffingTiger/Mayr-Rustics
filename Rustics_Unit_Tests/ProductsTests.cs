using Microsoft.VisualStudio.TestTools.UnitTesting;
using RusticsInventoryMVC.Controllers;
using System.Web.Mvc;
using RusticsInventoryMVC.Models;
using Moq;

namespace Rustics_Unit_Tests
{
    [TestClass]
    public class ProductsTests
    {
        [TestMethod]
        public void Create_Product_Returns_ActionResult()
        {
            ProductsController controller = new ProductsController();
            ActionResult result = controller.Create() as ActionResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }


    }
}
