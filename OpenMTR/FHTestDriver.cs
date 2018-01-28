using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMTR
{
    class FHTestDriver
    {
        FileHandler FH;
        public FHTestDriver(string directory)
        {
            FH = new FileHandler(directory);
        }

        public void test()
        {
            foreach (string FileName in FH.ImageNames)
            {
                DebugUtils.Log(FH.ImageDirectory + FileName);
                if (FH.MissingMetaData.Contains(FileName))
                {
                    Console.WriteLine("Metadata file is missing for " + FileName);
                    continue;
                }
                Console.WriteLine(System.IO.File.ReadAllLines(FH.MetaDirectory + FH.GetMetaFile(FileName))[0]);
            }
        }
    }
}
