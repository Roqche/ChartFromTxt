namespace ChartLogic
{
    public class Punkt
    {
        public Punkt(decimal time, decimal pd, decimal fn)
        {
            Time = time;
            Pd = pd;
            Fn = fn;
        }

        public decimal Time { get; set; }
        public decimal Pd { get; set; }
        public decimal Fn { get; set; }
    }
}