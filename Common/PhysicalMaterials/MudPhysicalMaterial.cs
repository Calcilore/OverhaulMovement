using OverhaulMovement.Common.Footsteps;
using OverhaulMovement.Common.Tags;
using OverhaulMovement.Core.PhysicalMaterials;
using OverhaulMovement.Core.Tags;
using Terraria.Audio;

namespace OverhaulMovement.Common.PhysicalMaterials;

public sealed class MudPhysicalMaterial : PhysicalMaterial, ITileTagAssociated, IFootstepSoundProvider
{
	public TagData TileTag { get; } = OverhaulTileTags.Mud;

	public SoundStyle? FootstepSound { get; } = new($"{nameof(OverhaulMovement)}/Assets/Sounds/Footsteps/Mud/Step", 6) {
		Volume = 0.5f,
	};
}
