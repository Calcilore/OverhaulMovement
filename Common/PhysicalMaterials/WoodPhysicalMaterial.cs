using OverhaulMovement.Common.Footsteps;
using OverhaulMovement.Common.Tags;
using OverhaulMovement.Core.PhysicalMaterials;
using OverhaulMovement.Core.Tags;
using Terraria.Audio;
using Terraria.ModLoader;

namespace OverhaulMovement.Common.PhysicalMaterials;

public sealed class WoodPhysicalMaterial : PhysicalMaterial, ITileTagAssociated, IFootstepSoundProvider
{
	public TagData TileTag { get; } = OverhaulTileTags.Wood;

	// Footsteps
	public SoundStyle? FootstepSound { get; } = new($"{nameof(OverhaulMovement)}/Assets/Sounds/Footsteps/Wood/Step", 11) {
		Volume = 0.5f,
	};

	public SoundStyle? JumpFootstepSound => ModContent.GetInstance<StonePhysicalMaterial>().JumpFootstepSound;
}
