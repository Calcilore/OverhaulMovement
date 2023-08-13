using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Core;
using Hook = OverhaulMovement.Common.Movement.IPlayerOnBunnyhopHook;

namespace OverhaulMovement.Common.Movement;

public interface IPlayerOnBunnyhopHook
{
	public static readonly HookList<ModPlayer> Hook = PlayerLoader.AddModHook(new HookList<ModPlayer>(typeof(IPlayerOnBunnyhopHook).GetMethod(nameof(OnBunnyhop))));

	void OnBunnyhop(Player player, ref float boost, ref float boostMultiplier);

	public static void Invoke(Player player, ref float boost, ref float boostMultiplier)
	{
		foreach (IPlayerOnBunnyhopHook g in Hook.Enumerate(player.ModPlayers)) {
			g.OnBunnyhop(player, ref boost, ref boostMultiplier);
		}
	}
}
