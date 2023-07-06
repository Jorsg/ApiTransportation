using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using apilfs.Controllers;
using Moq;
using apilfs.Repository.Interfaces;
using apilfs.Repository.Accessorial;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace TestApiLfs
{
    
    public class TestAccesorials 
    {
        AccesorialsController _controller;
        IAccesorials _service;
        apilfs.Models.BD_LFSContext _context;

        public TestAccesorials()
        {
            _service = new AccesorialsRespository(_context);
            _controller = new AccesorialsController(_service);
        }

        [TestMethod]
        public void ObtenerTodosLosAccesorials()
        {
            //Act
            var OkResult = _controller.GetAccesorials();

            //Assert
            Assert.IsNotNull(OkResult);

        }
    }
}
