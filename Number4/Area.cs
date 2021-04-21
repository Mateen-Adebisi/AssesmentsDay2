using System;
namespace Number4
{
    public class Rectangle
    {
        public class Area{


int length,breadth;
Area(int l, int b){
        length = l;
        breadth = b;
}
public int setDim(){
int results = length * breadth;
return results;
}
 public void getArea(){
Console.WriteLine("Area = " +  setDim());
}
 static void Main(string[] args)
        {
            
            Area area =new Area(17,89);
             area.getArea();
        }
      }  }
}