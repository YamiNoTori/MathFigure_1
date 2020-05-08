namespace CalcAreaLib
{
    public class CircleFabric : FigureFabric
    {
        public override IFigure createFigure(params double[] p)
        {
            return new Circle(p[0]);
        }
    }
}
