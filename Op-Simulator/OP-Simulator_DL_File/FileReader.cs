using OP_Simulator_BL.Interfaces;
using OP_Simulator_BL.Model;

namespace OP_Simulator_DL_File
{
    public class FileReader : IFileReader
    {
        /// <summary>
        /// Method to read names (first and last, files are formatted the same)
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="fileNames"></param>
        /// <returns></returns>
        public List<string> LeesNamen(string filePath)
        {
            var namen = new List<string>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    namen.Add(line.Split(';')[1].Trim());
                }
            }

            return namen;
        }

        public List<(int postcode, string gemeente)> LeesPostCodeGemeente(string filePath)
        {
            var pcgem = new List<(int postcode, string gemeente)>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] ss = line.Split(";");

                    if (!string.IsNullOrWhiteSpace(ss[0]))
                    {
                        pcgem.Add((int.Parse(ss[0].Trim()), ss[1].Trim()));
                    }
                }
            }

            return pcgem;
        }

        public List<string> LeesStraten(string filePath, string gemeente)
        {
            var straten = new List<string>();
            using(StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] ss = line.Split(',');
                    if (ss[0].Trim() == gemeente)
                    {
                        straten.Add(ss[2].Trim());
                    }
                }
            }

            return straten;
        }
    }
}
