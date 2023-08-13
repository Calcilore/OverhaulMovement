using OverhaulMovement.Common.Footsteps;
using OverhaulMovement.Common.Tags;
using OverhaulMovement.Core.PhysicalMaterials;
using OverhaulMovement.Core.Tags;
using Terraria.Audio;

namespace OverhaulMovement.Common.PhysicalMaterials;

public sealed class SnowPhysicalMaterial : PhysicalMaterial, ITileTagAssociated, IFootstepSoundProvider
{
	public TagData TileTag { get; } = OverhaulTileTags.Snow;

	public SoundStyle? FootstepSound { get; } = new($"{nameof(OverhaulMovement)}/Assets/Sounds/Footsteps/Snow/Step", 11) {
		Volume = 0.5f,
	};
}
