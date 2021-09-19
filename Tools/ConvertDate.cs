using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp1.Tools
{
    class ConvertDate
    {
        public string ConvertDateToMills(String pFecha)
        {
            DateTime miFecha;
            long datemilliseconds;
            string datemillisecondsStr;
            miFecha = DateTime.Parse(pFecha);
            Console.WriteLine("Fecha a convertir: " + miFecha);
            long unixTimeSeconds = new DateTimeOffset(miFecha).ToUnixTimeSeconds();
            datemilliseconds = unixTimeSeconds * 1000;
            datemillisecondsStr = datemilliseconds.ToString();
            return datemillisecondsStr;
        }
    }
}
