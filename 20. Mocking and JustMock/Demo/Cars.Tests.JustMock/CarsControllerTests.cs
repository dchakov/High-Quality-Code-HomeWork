namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;
    
    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            //: this(new JustMockCarsRepository())
             : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void GetDetailsOfCarByIdShouldReturnDetail()
        { 
            var car = (Car)this.GetModel(() => this.controller.Details(1));

            Assert.AreEqual(1, car.Id);
            Assert.AreEqual("Audi", car.Make);
            Assert.AreEqual("A5", car.Model);
            Assert.AreEqual(2005, car.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetDetailsOfCarByIdShouldThrowIfCarCouldNotBeFound()
        {
            var car = (Car)this.GetModel(() => this.controller.Details(15));
        }

        [TestMethod]
        public void SearchACarByModelShouldReturnCorrectResultBMWCount()
        {
            var carModels = (ICollection<Car>)this.GetModel(() => this.controller.Search("BMW"));

            Assert.AreEqual(2, carModels.Count);
        }

        [TestMethod]
        public void SearchACarByModelShouldReturnCorrectResultOpelCount()
        {
            var carModels = (ICollection<Car>)this.GetModel(() => this.controller.Search("Opel"));

            Assert.AreEqual(1, carModels.Count);
        }

        [TestMethod]
        public void SearchACarByModelShouldReturnCorrectResultAllModelsWhenEmptyCondition()
        {
            var carModels = (ICollection<Car>)this.GetModel(() => this.controller.Search(""));

            Assert.AreEqual(4, carModels.Count);
        }

        [TestMethod]
        public void SearchACarByModelShouldReturnCorrectResultZeroWhenWrongInput()
        {
            var carModels = (ICollection<Car>)this.GetModel(() => this.controller.Search("mercedec"));

            Assert.AreEqual(0, carModels.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortWithInvalidInputEmptyStringShoudThrow()
        {
            var carModels = (ICollection<Car>)this.GetModel(() => this.controller.Sort(""));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SortWithInvalidInputShoudThrow()
        {
            var carModels = (ICollection<Car>)this.GetModel(() => this.controller.Sort("A5"));
        }

        [TestMethod]
        public void SortedByMakeShouldBeCorrect()
        {
            var carModels = (IList<Car>)this.GetModel(() => this.controller.Sort("make"));

            Assert.AreEqual("Audi", carModels[0].Make);
            Assert.AreEqual("BMW", carModels[1].Make);
            Assert.AreEqual("BMW", carModels[2].Make);
            Assert.AreEqual("Opel", carModels[3].Make);
        }

        [TestMethod]
        public void SortedByYeareShouldBeCorrect()
        {
            var carModels = (IList<Car>)this.GetModel(() => this.controller.Sort("year"));

            Assert.AreEqual(2005, carModels[0].Year);
            Assert.AreEqual(2007, carModels[1].Year);
            Assert.AreEqual(2008, carModels[2].Year);
            Assert.AreEqual(2010, carModels[3].Year);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
