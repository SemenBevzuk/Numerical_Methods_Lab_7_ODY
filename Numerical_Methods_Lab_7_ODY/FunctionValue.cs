namespace Numerical_Methods_Lab_7_ODY
{
    class FunctionValue
    {
        public double V { get; private set; }
        public double VHalf { get; private set; }
        public double DeltaV { get; private set; }

        public FunctionValue(double v, double vHalf)
        {
            V = v;
            VHalf = vHalf;
            DeltaV = v-vHalf;
        }
    }
}