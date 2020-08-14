using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Scheduler
{
    class clsSchedule
    {

        public static int ConvertsTimeINToInt(string cTimeIn)
        {
            switch (cTimeIn)
            {
                case "7:00:00 AM":
                    return 1;
                case "7:30:00 AM":
                    return 2;
                case "8:00:00 AM":
                    return 3;
                case "8:30:00 AM":
                    return 4;
                case "9:00:00 AM":
                    return 5;
                case "9:30:00 AM":
                    return 6;
                case "10:00:00 AM":
                    return 7;
                case "10:30:00 AM":
                    return 8;
                case "11:00:00 AM":
                    return 9;
                case "11:30:00 AM":
                    return 10;
                case "12:00:00 PM":
                    return 11;
                case "12:30:00 PM":
                    return 12;
                case "1:00:00 PM":
                    return 13;
                case "1:30:00 PM":
                    return 14;
                case "2:00:00 PM":
                    return 15;
                case "2:30:00 PM":
                    return 16;
                case "3:00:00 PM":
                    return 17;
                case "3:30:00 PM":
                    return 18;
                case "4:00:00 PM":
                    return 19;
                case "4:30:00 PM":
                    return 20;
                case "5:00:00 PM":
                    return 21;
                case "5:30:00 PM":
                    return 22;
                case "6:00:00 PM":
                    return 23;
                case "6:30:00 PM":
                    return 24;
                default :
                    return 1;
            }

        }

        public static int ConvertsTimeOUTToInt(string cTimeOut)
        {
            switch (cTimeOut)
            {
                case "7:00:00 AM":
                    return 1;
                case "7:30:00 AM":
                    return  2;
                case "8:00:00 AM":
                    return 3;
                case "8:30:00 AM":
                    return 4;
                case "9:00:00 AM":
                    return 5;                   
                case "9:30:00 AM":
                    return 6;
                case "10:00:00 AM":
                    return 7;
                case "10:30:00 AM":
                    return 8;
                case "11:00:00 AM":
                    return 9;
                case "11:30:00 AM":
                    return 10;
                case "12:00:00 PM":
                    return 11;
                case "12:30:00 PM":
                    return 12;
                case "1:00:00 PM":
                    return 13;
                case "1:30:00 PM":
                    return 14;
                case "2:00:00 PM":
                    return 15;
                case "2:30:00 PM":
                    return 16;
                case "3:00:00 PM":
                    return 17;
                case "3:30:00 PM":
                    return 18;
                case "4:00:00 PM":
                    return 19;
                case "4:30:00 PM":
                    return 20;
                case "5:00:00 PM":
                    return 21;
                case "5:30:00 PM":
                    return 22;
                case "6:00:00 PM":
                    return 23;
                case "6:30:00 PM":
                    return 24;
                default:
                    return 1;
            }

        }

        public clsSchedule()
        { 
        }
    }
}
