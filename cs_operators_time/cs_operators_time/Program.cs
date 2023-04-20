
namespace _cs_operators_time
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time() {
            Hours = 12;
            Minutes = 12;
            Seconds= 12;
        }
        public Time(int hours, int minutes, int seconds) {
            try
            {
                if (hours < 24 && hours >= 0)
                {
                    Hours = hours;
                }
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            try
            {
                if(minutes < 60 && minutes >= 0)
                {
                    Minutes = minutes;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                if (seconds < 60 && seconds >= 0)
                {
                    Seconds= seconds;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public Time(int seconds)
        {
            Hours = seconds / 3600;
            Minutes = (seconds % 3600) / 60;
            Seconds = seconds % 60;
        }

        public void Reset()
        {
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
            Seconds = DateTime.Now.Second;
        }
        public void ToString()
        {
            Console.WriteLine($"Time: {Hours}:{Minutes}:{Seconds}");
        }

        public static Time operator ++(Time t)
        {
            t.Seconds++;
            if (t.Seconds == 60)
            {
                t.Seconds = 0;
                t.Minutes++;
                if (t.Minutes == 60)
                {
                    t.Minutes = 0;
                    t.Hours++;
                    if (t.Hours == 24)
                    {
                        t.Hours = 0;
                    }
                }
            }
            return t;
        }
        public static Time operator --(Time t)
        {
            t.Seconds--;
            if (t.Seconds < 0)
            {
                t.Seconds = 59;
                t.Minutes--;
                if(t.Minutes < 0)
                {
                    t.Minutes = 59;
                    t.Hours--;
                    if (t.Hours < 0)
                    {
                        t.Hours = 23;
                    }
                }
            }
            return t;
        }
        public static bool operator > (Time t1, Time t2)
        {
            if (t1.Hours == t2.Hours)
            {
                if (t1.Minutes == t2.Minutes)
                {
                    if(t1.Seconds > t2.Seconds)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (t1.Minutes> t2.Minutes)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if(t1.Hours > t2.Hours)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool operator <(Time t1, Time t2)
        {
            if (t1.Hours == t2.Hours)
            {
                if (t1.Minutes == t2.Minutes)
                {
                    if (t1.Seconds > t2.Seconds)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    if (t1.Minutes > t2.Minutes)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (t1.Hours > t2.Hours)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public static bool operator >=(Time t1, Time t2)
        {
            return !(t1 <t2);
        }
        public static bool operator <=(Time t1, Time t2)
        {
            return !(t1 > t2);
        }
        public static bool operator ==(Time t1, Time t2)
        {
            return t1.Equals(t2);
        }
        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }
        public static bool FutureTime(Time t1)
        {
            int hours = DateTime.Now.Hour;
            int minutes = DateTime.Now.Minute;
            int seconds = DateTime.Now.Second;

            if (t1.Hours == hours)
            {
                if (t1.Minutes == minutes)
                {
                    if(t1.Seconds < seconds)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                if (t1.Minutes < minutes)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if(t1.Hours < hours)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static public explicit operator TimeOnly(Time t)
        {
            return new TimeOnly(t.Hours, t.Minutes, t.Seconds);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time();

            t.Reset();

            t.ToString();
        }
    }
}