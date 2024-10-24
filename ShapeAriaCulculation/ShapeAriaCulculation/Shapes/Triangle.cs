namespace ShapeAriaCulculation.Shapes
{
    public class Triangle : ShapeBase
    {
        private static short _TRIANGLE_SIDES_COUNT = 3;

        private readonly double[] sides;

        public Triangle(double[] sides)
        {
            if (sides.Length != _TRIANGLE_SIDES_COUNT)
                throw new ArgumentException("Invalid triangle's parametrs count");

            if (!IsValidTriangle(sides))
                throw new ArgumentException("Invalid triangle's parametrs");

            this.sides = sides;
        }

        public bool IsRightTriangle()
        {
            var a = sides[0];
            var b = sides[1];
            var c = sides[2];

            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }

        public override double CalculateArea()
        {
            var a = sides[0];
            var b = sides[1];
            var c = sides[2];

            var s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        private bool IsValidTriangle(double[] sides)
            => sides[0] <= sides[1] + sides[2]
                && sides[1] <= sides[2] + sides[0]
                && sides[2] <= sides[0] + sides[1];
    }
}