using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace OverhaulMovement.Core.Configuration;

public class ServerConfig : ModConfig
{
	public override ConfigScope Mode => ConfigScope.ServerSide;
	public static ServerConfig Instance { get; private set; }
	
	public override void OnLoaded()
	{
		Instance = this;
	}
	
	[Header("PlayerMovement")]
	
	[DefaultValue(true)]
	public bool EnableVerticalMovementChanges { get; set; } = true;
	
	[DefaultValue(true)]
	public bool EnableHorizontalMovementChanges { get; set; } = true;
	
	[DefaultValue(true)]
	public bool PlayerFacesMouse { get; set; } = true;

	[DefaultValue(true)]
	public bool EnableAutoJump { get; set; } = true;

	[DefaultValue(true)]
	public bool EnableBunnyhopping { get; set; } = true;

	[DefaultValue(true)]
	public bool EnableWallJumping { get; set; } = true;

	[DefaultValue(true)]
	public bool EnableWallFlipping { get; set; } = true;

	[DefaultValue(true)]
	public bool EnableClimbing { get; set; } = true;

	[DefaultValue(true)]
	public bool EnableDodgeRolling { get; set; } = true;
}
