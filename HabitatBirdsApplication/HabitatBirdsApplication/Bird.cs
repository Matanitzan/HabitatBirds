using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitatBirdsApplication
{
    public class Bird
    {
        public string SerialNumber { get; set; }
        public string Species { get; set; }
        public string Subspecies { get; set; }
        public string HatchDate { get; set; }
        public string Gender { get; set; }
        public string CageNumber { get; set; }
        public string FatherSerial { get; set; }
        public string MotherSerial { get; set; }

        public Bird(string serialNumber, string species, string subspecies, string hatchDate, string gender, string cageNumber, string fatherSerial, string motherSerial)
        {
            SerialNumber = serialNumber;
            Species = species;
            Subspecies = subspecies;
            HatchDate = hatchDate;
            Gender = gender;
            CageNumber = cageNumber;
            FatherSerial = fatherSerial;
            MotherSerial = motherSerial;
        }
    }

}

