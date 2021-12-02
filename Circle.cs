using System;

namespace Assingment_9
{
    public class Circle
    {
        public float rad; // radius
        public void getRadius(float f1){
            rad = f1;
        }
        public float area(){
            float a = 3.14F*rad*rad;
            return a;
        }
        public float circumference(){
            float c = 3.14F*2*rad;
            return c;
        }
    }

}