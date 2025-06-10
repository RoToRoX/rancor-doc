using MessagePack;
using System.Collections.Generic;

namespace Rancor
{
    [MessagePackObject]
    public class RancorSimBaseDTO
    {
        [Key(0)] public int TrialTime { get; set; }
        [Key(1)] public int TrialLength { get; set; }
        [Key(2)] public bool Training { get; set; }
        [Key(3)] public string Clock { get; set; }
        [Key(4)] public double TotalGrossMW { get; set; }
        [Key(5)] public bool Pause { get; set; }
        [Key(6)] public bool UseSI { get; set; }
        [Key(7)] public List<string> UnitIdentifiers { get; set; }

        public static void GenerateSpecFile(string msgpackSpecFilePath)
        {
            MessagePackSpec.GenerateSpecFile<RancorSimBaseDTO>(msgpackSpecFilePath);
        }
    }
}
