using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Contracts.Interfaces;
using System.DataAccess.Context;
using System.DataAccess.Repos.RepoEntities;
using System.DataAccess.Repos;
using System.Contracts;
using System.DataAcces.Tests.Utilities;
using System_Contracts;
using System.Dominio.Entities;

namespace System.DataAcces.Tests
{
    [TestClass]
    public class FaseTests
    {
        private IFaseRepository _faseRepository;
        private IUnitOfWork _unitOfWork;
        private IRecetaRepository _recetaRepository;
        
        public FaseTests()
        {
            ApplicationContext context = new ApplicationContext(ConnectionStringProvider.GetConnectionString());
            _faseRepository = new FaseRepository(context);
            _unitOfWork = new UnitOfWork(context);
            _recetaRepository = new RecetaRepository(context);
        }
        [DataRow("SolidificacionXD","asdasd","FaseSolidificaion")]
        [TestMethod]
        public void Can_AddFase(string nombre, string code, string descripcion)
        {
            //Arrange
            Guid id= Guid.NewGuid();
            Fase fase = new Fase(id, nombre, code, descripcion);

            //Execute
            _faseRepository.AddFase(fase);
            _unitOfWork.SaveChanges();  

            //Assert
            Fase? loadedFase = _faseRepository.GetFaseByID(fase.Id);
            Assert.IsNotNull(loadedFase);   
        }
    }
}