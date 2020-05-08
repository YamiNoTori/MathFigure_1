namespace CalcAreaLib
{
    public class TriangleFabric : FigureFabric
    {
        public override IFigure createFigure(params double[] p)
        {
            return new Triangle(p);
        }
    }
}
