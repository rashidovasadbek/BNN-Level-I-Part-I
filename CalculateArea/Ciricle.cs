

namespace CalculateArea
{
    public sealed class Ciricle : shape
    {
        public  int Radus { get; set; }
        public Ciricle(int radus)
        {

            Radus = radus;

        }
        public override double CalculateArea()
        {
           return Math.PI * Math.Pow(Radus,2);
        }
    }
}
