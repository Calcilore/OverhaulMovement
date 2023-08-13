using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace OverhaulMovement.Core.Configuration;

public class ClientConfig : ModConfig
{
	public override ConfigScope Mode => ConfigScope.ClientSide;
	public static ClientConfig Instance { get; private set; }
	
	public override void OnLoaded()
	{
		Instance = this;
	}
	
	[Header("Visuals")]
	
	[Label("Enable Player Rotation")]
	[Tooltip("Disabling this will make the player not rotate when moving.")]
	[DefaultValue(true)]
	public bool EnablePlayerRotation { get; set; } = true;

	[Label("Enable Player Head Rotation")]
	[Tooltip("Disabling this will make the player's head not rotate when moving.")]
	[DefaultValue(true)]
	public bool EnablePlayerHeadRotation { get; set; } = true;

	[Label("Enable Player Footsteps")]
	[Tooltip("Disabling this will make the player not have footsteps.")]
	[DefaultValue(true)]
	public bool EnablePlayerFootsteps { get; set; } = true;
}
