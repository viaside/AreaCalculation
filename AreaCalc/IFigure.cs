using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public interface IFigure
    {
        string NameFigure { get; set; }

        double GetArea();
    }
}
