//using NUnit.Framework;
//using System;

//namespace HabitatBirdsApplication.Tests
//{
//    [TestFixture]
//    public class BirdTests
//    {
//        [Test]
//        public void Bird_Initialization()
//        {
//            Arrange
//            string serialNumber = "123456";
//            string species = "American Gouldian";
//            string subspecies = "North America";
//            string hatchDate = "2023-01-01";
//            string gender = "Male";
//            string cageNumber = "Cage1";
//            string fatherSerial = "789012";
//            string motherSerial = "345678";

//            Act
//           Bird bird = new Bird(serialNumber, species, subspecies, hatchDate, gender, cageNumber, fatherSerial, motherSerial);

//            Assert
//            Assert.AreEqual(serialNumber, bird.SerialNumber);
//            Assert.AreEqual(species, bird.Species);
//            Assert.AreEqual(subspecies, bird.Subspecies);
//            Assert.AreEqual(hatchDate, bird.HatchDate);
//            Assert.AreEqual(gender, bird.Gender);
//            Assert.AreEqual(cageNumber, bird.CageNumber);
//            Assert.AreEqual(fatherSerial, bird.FatherSerial);
//            Assert.AreEqual(motherSerial, bird.MotherSerial);
//        }
//    }

//    [TestFixture]
//    public class SearchBirdTests
//    {
//        [Test]
//        public void SearchBySerialNumber_Found()
//        {
//            Arrange
//            string serialNumber = "123456";
//            Bird bird = new Bird(serialNumber, "American Gouldian", "North America", "2023-01-01", "Male", "Cage1", "789012", "345678");
//            SearchBird searchBird = new SearchBird();

//            Act
//           Bird foundBird = searchBird.SearchBySerialNumber(serialNumber);

//            Assert
//            Assert.IsNotNull(foundBird);
//            Assert.AreEqual(serialNumber, foundBird.SerialNumber);
//        }

//        [Test]
//        public void SearchBySerialNumber_NotFound()
//        {
//            Arrange
//            string serialNumber = "999999";
//            SearchBird searchBird = new SearchBird();

//            Act
//           Bird foundBird = searchBird.SearchBySerialNumber(serialNumber);

//            Assert
//            Assert.IsNull(foundBird);
//        }
//    }

//    You can add more test classes for the NewBird class and other functionality

//   [TestFixture]
//    public class NewBirdTests
//    {
//        Add test methods to test the functionality of the NewBird class
//         ...
//    }
//}
