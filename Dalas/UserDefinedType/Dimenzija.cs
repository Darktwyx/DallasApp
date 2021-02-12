using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;


[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.Native)]
public struct Dimenzija : INullable
{
    int duzina;
    int sirina;
    int visina;

    public int Duzina { get => duzina; set => duzina = value; }
    public int Sirina { get => sirina; set => sirina = value; }
    public int Visina { get => visina; set => visina = value; }

    public bool is_Null;



    public bool IsNull
    {
        get { return is_Null; }
    }

    public override string ToString()
    {
        if (this.is_Null)
            return "NULL";
        else
        {
            return this.Duzina + "X" + this.Sirina + "X" + this.Visina;
        }
    }


    public static Dimenzija Null
    {
        get
        {
            Dimenzija dim = new Dimenzija();
            dim.is_Null = true;
            return dim;
        }
    }


    public static Dimenzija Parse(SqlString value)
    {
        if (value.IsNull)
            return Dimenzija.Null;

        Dimenzija dimenzija = new Dimenzija();
        try
        {
            string[] values = value.ToString().Split('X');
            dimenzija.Duzina = Convert.ToInt32(values[0].ToString());
            dimenzija.Sirina = Convert.ToInt32(values[1].ToString());
            dimenzija.Visina = Convert.ToInt32(values[2].ToString());

            return dimenzija;
        }
        catch (Exception)
        {
            throw;
        }
    }

}



