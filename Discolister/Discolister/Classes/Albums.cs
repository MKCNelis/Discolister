using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discolister.Classes
{
    public class Albums
    {
        //contacts class with properties
        [PrimaryKey, AutoIncrement]
        //AutoIncriment adds to ID
        public int Album_ID { get; set; }
        public string sAlbumTitle { get; set; }
        public string sAlbumSummary { get; set; }
        public string sBandName { get; set; }
        public int BandFK_ID { get; set; }

    }
}
