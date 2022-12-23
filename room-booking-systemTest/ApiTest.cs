using System.Xml.Linq;
using System;
using RoomBookingSystem;

namespace RoomBookingSystemTest
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public async Task ValidateLoginTestAsync1()
        {
            FunctionsClass functions = new FunctionsClass();
            int resp = await functions.validateLogin("nama", "password");
            Assert.AreEqual(resp, 1);

        }
        [TestMethod]
        public async Task ValidateLoginTestAsync3()
        {
            FunctionsClass functions = new FunctionsClass();
            int resp = await functions.validateLogin("string", "string");
            Assert.AreEqual(resp, 1);

        }
        [TestMethod]
        public async Task ValidateLoginTestAsync2()
        {
            FunctionsClass functions = new FunctionsClass();
            int resp = await functions.validateLogin("nama2", "password2");
            Assert.AreEqual(resp, 1);

        }
        [TestMethod]
        public async Task RegisterTestAsync1()
        {
            FunctionsClass functions = new FunctionsClass();
            int resp;
            try
            {
                string falseid = "123a";
                string id = int.Parse(falseid).ToString();
                resp = await functions.newUser("test1", id, "unametest1", "pass1");
            } catch (Exception ex)
            {
                resp = 0;
            }
            
            Assert.AreEqual(resp, 0);

        }
        [TestMethod]
        public async Task RegisterTestAsync2()
        {
            FunctionsClass functions = new FunctionsClass();
            int resp;
            try
            {
                resp = await functions.newUser("test2", "123", "unametest2", "pass2");
            }
            catch (Exception ex)
            {
                resp = 0;
            }
            Assert.AreEqual(resp, 1);

        }

        [TestMethod]
        public async Task ValidateUsernameTestAsync1()
        {
            FunctionsClass functions = new FunctionsClass();
            int resp = await functions.checkUserTakenAsync("unametest1");
            
            Assert.AreEqual(resp, 1);

        }

        [TestMethod]
        public async Task ValidateUsernameTestAsync2()
        {
            FunctionsClass functions = new FunctionsClass();
            int resp = await functions.checkUserTakenAsync("do not take this username because this username is for testing");

            Assert.AreEqual(resp, 1);

        }

        [TestMethod]
        public async Task NewBookingTestAsync1()
        {
            FunctionsClass functions = new FunctionsClass();
            string[] resp = await functions.newBooking("name", "123", "E1", "12/12/2022", "01", "ababa", "2");

            Assert.AreEqual(resp[0], "1");

        }

        [TestMethod]
        public async Task NewBookingTestAsync2()
        {
            FunctionsClass functions = new FunctionsClass();
            string[] resp = await functions.newBooking("name11", "123222", "E1", "23/12/2022", "00", "abaaaaaba", "1");

            Assert.AreEqual(resp[0], "1");

        }
    }
}