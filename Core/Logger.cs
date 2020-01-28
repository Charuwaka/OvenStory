using MvvmCross;
using MvvmCross.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class Logs
    {
        public static IMvxLog Instance { get; } = Mvx.IoCProvider.Resolve<IMvxLogProvider>().GetLogFor("Core");
    }
}
