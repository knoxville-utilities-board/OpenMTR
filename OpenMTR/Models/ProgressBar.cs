using System;
using System.Text;
using System.Threading;

namespace OpenMTR
{
    /// <summary>
    /// An ASCII progress bar
    /// https://gist.github.com/DanielSWolf/0ab6a96899cc5377bf54
    /// Console progress bar. Code is under the MIT License: http://opensource.org/licenses/MIT
    /// </summary>
    public class ProgressBar : IDisposable, IProgress<double>
    {
        private const int _blockCount = 10;
        private readonly TimeSpan _animationInterval = TimeSpan.FromSeconds(1.0 / 8);
        private const string _animation = @"|/-\";
        private readonly Timer _timer;
        private double _currentProgress = 0;
        private string _currentText = string.Empty;
        private bool _disposed = false;
        private int _animationIndex = 0;
        private string _title = "";

        public ProgressBar(string title = "")
        {
            _timer = new Timer(TimerHandler);
            _title = title;
            if (!Console.IsOutputRedirected)
            {
                ResetTimer();
            }
        }

        public void Report(double value)
        {
            value = Math.Max(0, Math.Min(1, value));
            Interlocked.Exchange(ref _currentProgress, value);
        }

        private void TimerHandler(object state)
        {
            lock (_timer)
            {
                if (_disposed) return;

                int progressBlockCount = (int)(_currentProgress * _blockCount);
                int percent = (int)(_currentProgress * 100);
                string text = string.Format("{0} [{1}{2}] {3,4}% {4}",
                    _title,
                    new string('#', progressBlockCount), new string('-', _blockCount - progressBlockCount),
                    percent,
                    _animation[_animationIndex++ % _animation.Length]);
                UpdateText(text);

                ResetTimer();
            }
        }

        private void UpdateText(string text)
        {
            int commonPrefixLength = 0;
            int commonLength = Math.Min(_currentText.Length, text.Length);
            while (commonPrefixLength < commonLength && text[commonPrefixLength] == _currentText[commonPrefixLength])
            {
                commonPrefixLength++;
            }
            StringBuilder outputBuilder = new StringBuilder();
            outputBuilder.Append('\b', _currentText.Length - commonPrefixLength);
            outputBuilder.Append(text.Substring(commonPrefixLength));
            int overlapCount = _currentText.Length - text.Length;
            if (overlapCount > 0)
            {
                outputBuilder.Append(' ', overlapCount);
                outputBuilder.Append('\b', overlapCount);
            }

            Console.Write(outputBuilder);
            _currentText = text;
        }

        private void ResetTimer()
        {
            _timer.Change(_animationInterval, TimeSpan.FromMilliseconds(-1));
        }

        public void Dispose()
        {
            lock (_timer)
            {
                _disposed = true;
                UpdateText(string.Empty);
            }
        }

    }
}