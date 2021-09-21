using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaWinForms_V._0._1
{
    [Serializable]
    public class Statistic
    {
        public int SymbolCounter { get; set; }
        public int MinuteToSecond { get; set; }
        public int Second { get; set; }
        public int WrongCounter { get; set; }
        public int PercentWrong { get; set; }
        public DateTime timeStatistic { get; set; }


        public Statistic()
        {
            SymbolCounter = default;
            MinuteToSecond = default;
            Second = default;
            WrongCounter = default;
            PercentWrong = default;
            timeStatistic = new DateTime();
        }

        private void CalcPercent()
        {
            if (SymbolCounter != 0 && WrongCounter != 0)
                PercentWrong = 100 * WrongCounter / SymbolCounter;
            else
                PercentWrong = 0;
            if (SymbolCounter <= WrongCounter)
                PercentWrong = 100;
        }
        public void CreateStatistic(int CountSymbol, int CountWrong, DateTime StartTime)
        {

            DateTime timeEnd = DateTime.Now;
            TimeSpan result = timeEnd - StartTime;
            int SecondTmp = (int)result.TotalSeconds;
            int MinuteTmp = (int)result.TotalMinutes * 60;
            Second = SecondTmp - MinuteTmp;
            MinuteToSecond = MinuteTmp / 60;
            SymbolCounter = CountSymbol;
            WrongCounter = CountWrong;
            timeStatistic = DateTime.Now;
            CalcPercent();
            ShowStatistic();
        }

        public string ToListStatistics()
        {
            return $"{timeStatistic}-\t{SymbolCounter} symbol, Time: {MinuteToSecond}:{Second}, wrong: {WrongCounter} ({PercentWrong}%)";
        }

        public string ShowStatistic()
        {
            return $"{SymbolCounter} Symbol\nTime: {MinuteToSecond}:{Second}\nWrong: {WrongCounter} ({PercentWrong}%)";
        }
    }
}
