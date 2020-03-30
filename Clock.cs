namespace ClockV10
{
    public class Clock
    {
        private int _timeInMinutesSince0000;
        public int timeInMinutes
        {
            get{return _timeInMinutesSince0000%60;}
        }
        public int timeInHours
        {
            get{return _timeInMinutesSince0000/60;}
        }
        public void SetTime(int hours, int minutes)
        {
            _timeInMinutesSince0000 = 60*hours+minutes;
        }
        public void DisplayTime()
        {   
            System.Console.WriteLine($"The time is {timeInHours} {timeInMinutes}");
        }
        
        
    }
}