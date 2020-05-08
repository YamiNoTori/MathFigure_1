namespace CalcAreaLib
{
    public class FigureController
    {
        // TODO: Желательно сделать это через обобщения
        public IFigure Figure { get; private set; }


        public void CreateCircle(double r)
        {
            FigureFabric fabric = new CircleFabric();
            Figure = fabric.createFigure(r);
        }

        public void CreateTriangle(double[] sides)
        {
            FigureFabric fabric = new TriangleFabric();
            Figure = fabric.createFigure(sides);
        }
    }
}
