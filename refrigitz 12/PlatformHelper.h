#pragma once

namespace System
{
	namespace Threading
	{

		//[field: NonSerialized]
		class PlatformHelper final
		{

		private:
			static const int PROCESSOR_COUNT_REFRESH_INTERVAL_MS = 0x7530;
			static volatile int s_lastProcessorCountRefreshTicks;
			static volatile int s_processorCount;

		public:
			const static bool &getIsSingleProcessor() const;

			const static int &getProcessorCount() const;
		};
	}
}
