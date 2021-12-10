using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discolister.Classes
{
    public class Bands
    {
        //contacts class with properties
        [PrimaryKey, AutoIncrement]
        //AutoIncriment adds to ID
        public int iBand_ID { get; set; }
        public string sBandName { get; set; }
        public string sBandSummary { get; set; }
        public string sSongTitle { get; set; }
        public int iSongFK_ID { get; set; }
    }
}
