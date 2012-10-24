This project exists to allow profiling EntityFramework with the MiniProfiler version included in [ServiceStack](https://github.com/ServiceStack/ServiceStack).
It replaces the MiniProfiler.EF package with a DLL built against ServiceStack, so that EF profiling will work with the built in profiler.

This code is essentially a fork of the project found [here](https://github.com/MiniProfiler/MiniProfiler/tree/master/StackExchange.Profiling.EntityFramework), but changed to use the ServiceStack profiler (namespaces fixed and compiled against ServiceStack).
To use, reference ServiceStack.MiniProfiler.EntityFramework, then follow the instructions from the original MiniProfiler project.