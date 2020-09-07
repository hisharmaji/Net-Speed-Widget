using System.Diagnostics;

namespace NetSpeedWidget
{
    /// <summary>
    /// Represents a network adapter installed on the machine.
    /// Properties of this class can be used to obtain current network speed.
    /// </summary>
    public class NetworkAdapter
    {
        /// <summary>
        /// Current download speed in bytes per second.
        /// </summary>
        public long DownloadSpeed { get; private set; }
        /// <summary>
        /// Current upload speed in bytes per second.
        /// </summary>
        public long UploadSpeed { get; private set; }

        private long dlValue, ulValue;              // Download\Upload counter value in bytes.
        private long dlValueOld, ulValueOld;        // Download\Upload counter value one second earlier, in bytes.

        internal string name;                               // The name of the adapter.
        public string Name => this.name;

        internal PerformanceCounter dlCounter, ulCounter;   // Performance counters to monitor download and upload speed.

        /// <summary>
        /// Instances of this class are supposed to be created only in an NetworkMonitor.
        /// </summary>
        internal NetworkAdapter(string name) => this.name = name;

        /// <summary>
        /// Preparations for monitoring.
        /// </summary>
        internal void Init()
        {
            // Since dlValueOld and ulValueOld are used in method refresh() to calculate network speed, they must have be initialized.
            dlValueOld = dlCounter.NextSample().RawValue;
            ulValueOld = ulCounter.NextSample().RawValue;
        }

        /// <summary>
        /// Obtain new sample from performance counters, and refresh the values saved in dlSpeed, ulSpeed, etc.
        /// This method is supposed to be called only in NetworkMonitor, one time every second.
        /// </summary>
        internal void Refresh()
        {
            dlValue = dlCounter.NextSample().RawValue;
            ulValue = ulCounter.NextSample().RawValue;

            // Calculates download and upload speed.
            DownloadSpeed = dlValue - dlValueOld;
            UploadSpeed = ulValue - ulValueOld;

            dlValueOld = dlValue;
            ulValueOld = ulValue;
        }

        /// <summary>
        /// Overrides method to return the name of the adapter.
        /// </summary>
        /// <returns>The name of the adapter.</returns>
        public override string ToString() => this.name;
    }
}
