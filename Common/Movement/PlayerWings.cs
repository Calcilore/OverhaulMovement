using OverhaulMovement.Utilities;
using Terraria.ModLoader;

namespace OverhaulMovement.Common.Movement;

public sealed class PlayerWings : ModPlayer
{
	public Timer WingsCooldown { get; set; }

	public override void PreUpdate()
	{
		// No Wings Time
		if (WingsCooldown.Active) {
			Player.wingsLogic = 0;
		}
	}
}
