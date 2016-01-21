using System.Reflection;
using System.Security;

[assembly: AssemblyProduct("Common Logging Framework log4net 1.2.13 Adapter")]

#if (!NETCF)
[assembly: SecurityTransparent]
#endif