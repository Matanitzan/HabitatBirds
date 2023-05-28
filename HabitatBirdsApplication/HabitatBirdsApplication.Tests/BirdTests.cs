//using NUnit.Framework;
//using HabitatBirdsApplication;

//namespace HabitatBirdsApplicationTests
//{
//    [TestFixture]
//    public class NewBirdTests
//    {
//        private NewBird newBird;

//        [SetUp]
//        public void Setup()
//        {
//            newBird = new NewBird();
//        }

//        [Test]
//        public void IsValidSerial_WhenSerialNumberIsEmpty_ReturnsFalse()
//        {
//            bool result = newBird.isValidSerial("", "Serial Number");
//            Assert.IsFalse(result);
//        }

//        [Test]
//        public void IsValidSerial_WhenSerialNumberContainsNonDigits_ReturnsFalse()
//        {
//            bool result = newBird.isValidSerial("123a", "Serial Number");
//            Assert.IsFalse(result);
//        }

//        [Test]
//        public void IsValidSerial_WhenSerialNumberIsValid_ReturnsTrue()
//        {
//            bool result = newBird.isValidSerial("1234", "Serial Number");
//            Assert.IsTrue(result);
//        }

//        [Test]
//        public void IsSerialNumberUnique_WhenSerialNumberExistsInExcel_ReturnsFalse()
//        {
//            string existingSerialNumber = "1234";
//            bool result = newBird.IsSerialNumberUnique(existingSerialNumber);
//            Assert.IsFalse(result);
//        }

//        [Test]
//        public void IsSerialNumberUnique_WhenSerialNumberDoesNotExistInExcel_ReturnsTrue()
//        {
//            string nonExistingSerialNumber = "5678";
//            bool result = newBird.IsSerialNumberUnique(nonExistingSerialNumber);
//            Assert.IsTrue(result);
//        }
//    }
//}
