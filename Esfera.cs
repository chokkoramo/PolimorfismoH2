using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Esfera : FiguraGeometrica
{
    private double radio;

    public Esfera(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return 4 * Math.PI * radio * radio;
    }

    public override double CalcularDiametro()
    {
        return 2 * radio;
    }
}