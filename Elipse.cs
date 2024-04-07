using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Elipse : FiguraGeometrica
{
    private double radioMayor;
    private double radioMenor;

    public Elipse(double radioMayor, double radioMenor)
    {
        this.radioMayor = radioMayor;
        this.radioMenor = radioMenor;
    }

    public override double CalcularArea()
    {
        return Math.PI * radioMayor * radioMenor;
    }

    public override double CalcularDiametro()
    {
        return Math.Sqrt(Math.Pow(radioMayor, 2) + Math.Pow(radioMenor, 2));
    }
}
