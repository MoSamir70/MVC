namespace FirstMVC.Models
{
    public class testClass
    {
        public int Add(int x, int y)
        {

            // Var is a keyword while dynamic is type
            // dynamic may exception in run time
            // No outo complete with dynamic

            dynamic xx = 5;
            dynamic yy = "ahmed";
            dynamic obj = new Student();

           
            yy = xx + obj;
            return x + y;
        }

        public void display()
        {
            int a = 10;
            int b = 20;
            Add(a, b);
        }
    }
}
