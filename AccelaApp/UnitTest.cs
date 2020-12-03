using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelaApp
{

    [TestClass]
    public class UnitTest
    {
        Person person = new Person();
        Address address = new Address();

        [TestMethod]
        public void AddPersonTest()
        {
            Assert.IsTrue(person.AddPerson("UnitTestFirstName", "UnitTestSecondName"));
        }

        [TestMethod]
        public void AddAddressTest()
        {
            using (var db = new AccelaEntities())
            {
                var result = db.PersonModels.Select(b => b.PERSON_ID).FirstOrDefault();
                Assert.IsTrue(address.AddAddress(result.ToString(), "street", "city", "state", "postcode"));
            }
        }

        [TestMethod]
        public void EditPersonTest()
        {
            using (var db = new AccelaEntities())
            {
                var result = db.PersonModels.Select(b => b.PERSON_ID).FirstOrDefault();
                Assert.IsTrue(person.EditPerson(result, "UnitTestFirstName", "UnitTestSecondName"));
            }
        }

        [TestMethod]
        public void EditAddressTest()
        {
            using (var db = new AccelaEntities())
            {
                var result = db.AddressModels.Select(b => b.ADDRESS_ID).FirstOrDefault();
                Assert.IsTrue(address.EditAddress(result, "street", "city", "state", "postcode"));
            }
        }

        [TestMethod]
        public void CountPeopleTest()
        {
            Assert.IsNotNull(person.CountPerson());
        }

        [TestMethod]
        public void ListPeopleTest()
        {
            Assert.IsNotNull(person.ListPersons());
        }

    }
}
