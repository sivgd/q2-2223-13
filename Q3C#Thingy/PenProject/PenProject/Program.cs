using System;

namespace PenProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen steveTheYellowHighlighter = new Pen();
            steveTheYellowHighlighter.Name = "Yellow Steve";
            steveTheYellowHighlighter.Color = "Yellow";
            steveTheYellowHighlighter.HasCap = true;
            steveTheYellowHighlighter.InkLevelPercent = 80.0f;
            steveTheYellowHighlighter.Length = 13.5f;
            steveTheYellowHighlighter.NumberPerBox = 12;
            steveTheYellowHighlighter.Price = 0.85f;
            steveTheYellowHighlighter.isEmpty = false;
            

            Pen blackSharpie = new Pen("A black Sharpie", "black",true,false,12.3f,0.79f,12,50.0f);
            blackSharpie.Uncap();
            blackSharpie.CheckInkLevel();
            blackSharpie.Write();
            blackSharpie.CheckInkLevel();

            while (blackSharpie.InkLevelPercent > 0)
            {

                blackSharpie.CheckInkLevel();
                blackSharpie.Write();
                blackSharpie.CheckInkLevel();


            }

            steveTheYellowHighlighter.Throw();
        }
    }
}
