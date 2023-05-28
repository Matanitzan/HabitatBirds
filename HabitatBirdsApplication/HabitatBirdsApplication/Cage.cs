using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitatBirdsApplication
{
    internal class Cage
    {
        public string serialNumber { set; get; }
        public float lenght { set; get; } 
        public float width { set; get; }
        public float Heigth { set; get; }
        public string material { set; get; }


        public Cage(string serial,string material,float l,float w,float h)
        {
            setSerial(serial);
            setMaterial(material);
            setlenght(l);
            setWidth(w);
            setHeigth(h);
        }
        //set get for serial
        public void setSerial(string serial)
        {
            this.serialNumber = serial;
        }
        public string getSerial() { return this.serialNumber; }


        //set get for material
        public void setMaterial(string material)
        {
            this.material = material;
        }
        public string getMaterial() { return this.material; }


        //set get for lenght
        public void setlenght(float l)
        {
            this.lenght = l;
        }
        public float getLenght() { return this.lenght; }


        //set get for width
        public void setWidth(float w)
        {
            this.width = w;
        }
        public float getWidth() { return this.width; }
        

        //set get for heigth
        public void setHeigth(float h)
        {
            this.Heigth = h;
        }
        public float getHeigth() { return this.Heigth; }




    }
}
