using System;
using System.Collections.Generic;
using System.Text;

namespace K_Factor_Shared
{
    public class Generator
    {
        private List<int> kvalues;

        public List<int> Kvalues { get => kvalues; set => kvalues = value; }

        private string ReadTemplate()
        {
            return Constants.TemplateString;
        }
        
        public string GenerateGCode(int nozzle, int bed, int startK = 0, int endK = 100)
        {
            int krange = endK - startK;
            int kstep = (int)krange / 10;
            Kvalues = new List<int>();
            for(int count = 0; count < 10; count++)
            {
                Kvalues.Add(startK + (count * kstep));
            }
            
            var template = ReadTemplate();
            return string.Format(template, nozzle, bed, Kvalues[0],
                Kvalues[1],
                Kvalues[2],
                Kvalues[3],
                Kvalues[4],
                Kvalues[5],
                Kvalues[6],
                Kvalues[7],
                Kvalues[8],
                Kvalues[9],
                endK);
        }
    }
}
