using OverhaulMovement.Core.Configuration;
using Terraria;
using Terraria.ModLoader;

namespace OverhaulMovement.Common.Movement;

public sealed class PlayerAutoJump : ModPlayer
{
	public override void ResetEffects()
	{
		if (ServerConfig.Instance.EnableAutoJump) {
			Player.autoJump = true;
		}
	}
}
