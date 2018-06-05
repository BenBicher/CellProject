using System;
using Cell.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRMUnitTest
{
    [TestClass]
    public class DALTest
    {
        private ClientRepository _clientRepo;

        public DALTest()
        {
            _clientRepo = new ClientRepository();
        }
        [TestMethod]
        public void IS_ADD_CLIENT_ADDED_TO_DB_SUCCESSFULLY()
        {

        }
    }
}
