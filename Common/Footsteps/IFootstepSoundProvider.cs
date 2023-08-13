using Terraria.Audio;

namespace OverhaulMovement.Common.Footsteps;

public interface IFootstepSoundProvider
{
	SoundStyle? FootstepSound { get; }

	SoundStyle? JumpFootstepSound => FootstepSound;
	SoundStyle? LandFootstepSound => FootstepSound;
}
