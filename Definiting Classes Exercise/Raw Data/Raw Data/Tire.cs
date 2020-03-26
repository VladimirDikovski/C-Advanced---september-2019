
namespace DefiningClasses
{
  public  class Tire
    {
        public int Age { get; set; }
        public double Pressure { get; set; }

        public Tire()
        {

        }
        public Tire(int age,double pressuare)
        {
            this.Age = age;
            this.Pressure = pressuare;
        }
    }
}
