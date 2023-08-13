using OverhaulMovement.Common.Footsteps;
using OverhaulMovement.Common.Tags;
using OverhaulMovement.Core.PhysicalMaterials;
using OverhaulMovement.Core.Tags;
using Terraria.Audio;

namespace OverhaulMovement.Common.PhysicalMaterials;

public sealed class SandPhysicalMaterial : PhysicalMaterial, ITileTagAssociated, IFootstepSoundProvider
{
	public TagData TileTag { get; } = OverhaulTileTags.Sand;

	public SoundStyle? FootstepSound { get; } = new($"{nameof(OverhaulMovement)}/Assets/Sounds/Footsteps/Sand/Step", 11) {
		Volume = 0.5f,
	};
}
