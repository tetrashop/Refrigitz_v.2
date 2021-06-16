#include "PlatformHelper.h"

namespace System
{
	namespace Threading
	{
volatile int PlatformHelper::s_lastProcessorCountRefreshTicks = 0;
volatile int PlatformHelper::s_processorCount = 0;

		const bool &PlatformHelper::getIsSingleProcessor() const
		{
			return (getProcessorCount() == 1);
		}

		const int &PlatformHelper::getProcessorCount() const
		{
			int tickCount = Environment::TickCount;
			int num2 = s_processorCount;
			if ((num2 == 0) || ((tickCount - s_lastProcessorCountRefreshTicks) >= 0x7530))
			{
				s_processorCount = num2 = Environment::ProcessorCount;
				s_lastProcessorCountRefreshTicks = tickCount;
			}
			return num2;
		}
	}
}
