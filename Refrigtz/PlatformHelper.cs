
namespace System.Threading
{

    using System;
    //#pragma warning disable CS0657 // 'field' is not a valid attribute location for this declaration. Valid attribute locations for this declaration are 'type'. All attributes in this block will be ignored.
    [field: NonSerialized]
    //#pragma warning restore CS0657 // 'field' is not a valid attribute location for this declaration. Valid attribute locations for this declaration are 'type'. All attributes in this block will be ignored.
    internal static class PlatformHelper
    {

        private const int PROCESSOR_COUNT_REFRESH_INTERVAL_MS = 0x7530;
        private static volatile int s_LastProcessorCountRefreshTicks;
        private static volatile int s_ProcessorCount;

        internal static bool IsSingleProcessor
        {
            get
            {
                return (ProcessorCount == 1);
            }
        }

        internal static int ProcessorCount
        {
            get
            {
                int tickCount = Environment.TickCount;
                int num2 = s_ProcessorCount;
                if ((num2 == 0) || ((tickCount - s_LastProcessorCountRefreshTicks) >= 0x7530))
                {
                    s_ProcessorCount = num2 = Environment.ProcessorCount;
                    s_LastProcessorCountRefreshTicks = tickCount;
                }
                return num2;
            }
        }
    }
}