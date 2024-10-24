using ShapeAriaCulculation.Enums;
using ShapeAriaCulculation.Shapes;

namespace ShapeAriaCulculation.Factory
{
    public static class ShapeFactory
    {
        public static ShapeBase CreateShape(ShapeTypeEnum shapeType, params object[] parameters)
        {
            switch (shapeType)
            {
                case ShapeTypeEnum.Circle:
                    return CreateCircle(parameters);
                case ShapeTypeEnum.Triangle:
                    return CreateTriangle(parameters);
                default:
                    throw new ArgumentException("Unsupported shape type");
            }
        }

        private static Circle CreateCircle(params object[] parameters)
            => new Circle((double) parameters[0]);

        private static Triangle CreateTriangle(params object[] parameters)
        {
            try
            {
                return new Triangle(parameters.Select(x => Convert.ToDouble(x)).ToArray());
            }
            catch (FormatException e)
            {
                throw new ArgumentException("Unsupported parametrs", e); ;
            }
        }
    }
}
