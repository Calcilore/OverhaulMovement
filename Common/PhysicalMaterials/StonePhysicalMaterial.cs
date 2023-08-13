using OverhaulMovement.Common.Footsteps;
using OverhaulMovement.Common.Tags;
using OverhaulMovement.Core.PhysicalMaterials;
using OverhaulMovement.Core.Tags;
using Terraria.Audio;

namespace OverhaulMovement.Common.PhysicalMaterials;

public sealed class StonePhysicalMaterial : PhysicalMaterial, ITileTagAssociated, IFootstepSoundProvider
{
	public TagData TileTag { get; } = OverhaulTileTags.Stone;
	// Footsteps
	public SoundStyle? FootstepSound { get; } = new($"{nameof(OverhaulMovement)}/Assets/Sounds/Footsteps/Stone/Step", 8) {
		Volume = 0.5f,
	};
	public SoundStyle? JumpFootstepSound { get; } = new($"{nameof(OverhaulMovement)}/Assets/Sounds/Footsteps/Stone/Jump", 3) {
		Volume = 0.5f,
	};
}
