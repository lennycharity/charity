using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Calculate
    {
        public double Add(double x , double y)
        {
            return x + y;
        }
        public double Division(double x , double y)
        {
            
            return x / y;
        }
        public double Multiplication(double x , double y)

        {
            
           
            return x*y;
        }
        public double subtraction(double x, double y)
        {
            
            if(x==0)
            {
                throw new Exception("x should not be zero");

            }
            else
            {
                return x - y;
            }
        }

    }

}