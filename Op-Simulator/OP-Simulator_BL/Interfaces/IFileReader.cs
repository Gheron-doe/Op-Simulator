using OP_Simulator_BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Simulator_BL.Interfaces
{
    public interface IFileReader
    {
        List<Klant> LeesBestanden(string folderPath, List<string> fileNames);
    }
}
