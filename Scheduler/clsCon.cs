using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace Scheduler
{

    class clsCon
    {
       
    public static  OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + "\\Data\\scheduling.mdb");

    public static bool CheckTextBox(TextBox txt , string sMSG = "TextBox", bool ShowMSG = true)
    {
        bool Temp =true;
        if(txt.Text== "")
        {
            if(ShowMSG)
            MessageBox.Show(sMSG,"",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            txt.Text ="";
            txt.Focus();
            Temp = true;
        }
        else
        {Temp =false;}
        return Temp;
    }

    public static void fillCombo(ComboBox cmb, string sSQL)
    {
        OleDbCommand Com = new OleDbCommand(sSQL,con);
        OleDbDataReader reader = Com.ExecuteReader();
        cmb.Items.Clear();
        while (reader.Read())
        {
            cmb.Items.AddRange(new object[] { reader[0].ToString() });
        }
        reader.Close();
    }

    public static int YLTitleToID(string sTitle)
    {
        switch (sTitle)
        {
            case "I":
                return 1;
            case "II":
                return 2;
            case "III":
                return 3;
            case "IV":
                return 4;
            default:
                return 0;
        }
    }

    public static string YLIDtoTitle(int iLYID)
    {
        switch(iLYID)
        {
            case 1:
                return "I";
            case 2:
                return "II";
            case 3:
                return "III";
            case 4:
                return "IV";
            default:
                return "0";
        }
    }


    
    public clsCon()
    {}


    }
}
