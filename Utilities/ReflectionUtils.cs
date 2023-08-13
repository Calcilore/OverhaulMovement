using System.Reflection;

namespace OverhaulMovement.Utilities;

public static class ReflectionUtils
{
	public const BindingFlags AnyBindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;
}
