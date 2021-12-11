using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discolister.Classes
{
    class Users
    {
        //contacts class with properties
        [PrimaryKey, AutoIncrement]
        //AutoIncriment adds to ID
        public int User_ID { get; set; }
        public string eUserName { get; set; }
        public string eEmail { get; set; }
        public string ePassword { get; set; }   
    }

}
