using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;

        public void Start()
        {
            if(_running)
                throw new InvalidOperationException("Stopwatch is already running!");
            Console.WriteLine("Start Time: {0}", _startTime = DateTime.Now);
            _running = true;
        }

        public void Stop()
        {
            if(!_running)
                throw new InvalidOperationException("Stopwatch is already stopped!");
            Console.WriteLine("End Time: {0}", _endTime = DateTime.Now);
            _running = false;
        }

        public TimeSpan Duration()
        {
            return _endTime - _startTime;
        }
    }
}
