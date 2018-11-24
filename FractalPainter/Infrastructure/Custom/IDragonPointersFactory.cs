using FractalPainting.App.Fractals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalPainting.Infrastructure.Custom
{
    public interface IDragonPointersFactory
    {
            DragonPainter CreateDragonPointer(DragonSettings dragonSettings);
    }
}
