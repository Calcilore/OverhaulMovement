using Terraria;
using Terraria.DataStructures;

namespace OverhaulMovement.Utilities;

public static class Point16Extensions
{
	public static bool IsInWorld(this Point16 point) => point.X >= 0 && point.Y >= 0 && point.X < Main.maxTilesX && point.Y < Main.maxTilesY;
}
