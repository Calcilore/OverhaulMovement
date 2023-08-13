﻿using OverhaulMovement.Core.Tags;
using Terraria.ID;
using Terraria.ModLoader;
using OverhaulMovement.Utilities;
using Group = OverhaulMovement.Core.Tags.TileTags;

namespace OverhaulMovement.Common.Tags;

public sealed class OverhaulTileTags : ILoadable
{
	/// <summary> Makes the tile count as something that would cause reverberation. </summary>
	public static readonly TagData Reverb = ContentTags.Get<TileTags>(nameof(Reverb));

	/// <summary> Affects footstep sounds. </summary>
	public static readonly TagData Dirt = ContentTags.Get<TileTags>(nameof(Dirt));

	/// <summary> Affects footstep sounds. </summary>
	public static readonly TagData Stone = ContentTags.Get<TileTags>(nameof(Stone));

	/// <summary> Affects footstep sounds. </summary>
	public static readonly TagData Grass = ContentTags.Get<TileTags>(nameof(Grass));

	/// <summary> Affects footstep sounds. </summary>
	public static readonly TagData Sand = ContentTags.Get<TileTags>(nameof(Sand));

	/// <summary> Affects footstep sounds. </summary>
	public static readonly TagData Snow = ContentTags.Get<TileTags>(nameof(Snow));

	/// <summary> Affects footstep sounds. </summary>
	public static readonly TagData Wood = ContentTags.Get<TileTags>(nameof(Wood));

	/// <summary> Affects footstep sounds. </summary>
	public static readonly TagData Mud = ContentTags.Get<TileTags>(nameof(Mud));

	/// <summary> Used for platforms. </summary>
	public static readonly TagData AllowClimbing = ContentTags.Get<TileTags>(nameof(AllowClimbing));

	/// <summary> Prevents water evaporation around this block. </summary>
	public static readonly TagData Cold = ContentTags.Get<TileTags>(nameof(Cold));

	/// <summary> Makes fire activate tiles like dynamite in wiring. </summary>
	public static readonly TagData FireActivated = ContentTags.Get<TileTags>(nameof(FireActivated));

	/// <summary> Tiles with this tag will not be destroyed by fire. Used by bushes & trees. </summary>
	public static readonly TagData FireImmune = ContentTags.Get<TileTags>(nameof(FireImmune));

	/// <summary> Makes the tile flammable. </summary>
	public static readonly TagData Flammable = ContentTags.Get<TileTags>(nameof(Flammable));

	/// <summary> Raises temperature, automatically results in <see cref="TileNoBeeHives"/> tag being added. </summary>
	public static readonly TagData HeatSource = ContentTags.Get<TileTags>(nameof(HeatSource));

	/// <summary> Bee hives never fall on it's own when close to this tile. </summary>
	public static readonly TagData Jungle = ContentTags.Get<TileTags>(nameof(Jungle));

	/// <summary> Like metallic, but *always* attracts lightning. </summary>
	public static readonly TagData LightningRod = ContentTags.Get<TileTags>(nameof(LightningRod));

	/// <summary> Makes tile attract lightning and conduct electricity. </summary>
	public static readonly TagData Metallic = ContentTags.Get<TileTags>(nameof(Metallic));

	/// <summary> Raises temperature, automatically results in <see cref="TileNoBeeHives"/> tag being added. </summary>
	public static readonly TagData NoClimbing = ContentTags.Get<TileTags>(nameof(NoClimbing));

	/// <summary> Tiles with this tag will not spread fire onto other blocks. Used for things that never actually get destroyed by fire, like bushes. </summary>
	public static readonly TagData NoFireSpreading = ContentTags.Get<TileTags>(nameof(NoFireSpreading));

	/// <summary> Monsters can spot players through this tile. </summary>
	public static readonly TagData Transparent = ContentTags.Get<TileTags>(nameof(Transparent));

	void ILoadable.Load(Mod mod)
	{
		// Footsteps

		Grass.PopulateFromSets(TileID.Sets.Grass);
		Grass.SetMultiple(new int[] {
			TileID.HayBlock,
			TileID.JungleGrass,
			TileID.MushroomGrass,
			//TileID.LeafBlock,
			//TileID.LivingMahoganyLeaves,
			//TileID.PineTree,
		});

		Dirt.SetMultiple(new int[] {
			TileID.Dirt,
			TileID.ClayBlock,
			TileID.Ash,
			TileID.Silt,
			TileID.Slush,
			TileID.Hive,
			//TileID.Mud,
		});

		Stone.SetMultiple(new int[] {
			TileID.Stone,
			TileID.StoneSlab,
			TileID.ActiveStoneBlock,
			TileID.SandStoneSlab,
			TileID.GrayBrick,
			// Moss
			TileID.ArgonMoss,
			TileID.BlueMoss,
			TileID.BrownMoss,
			TileID.GreenMoss,
			TileID.KryptonMoss,
			TileID.LavaMoss,
			TileID.RedMoss,
			TileID.PurpleMoss,
			TileID.XenonMoss,
			// Evil
			TileID.Ebonstone,
			TileID.Crimstone,
			TileID.Pearlstone,
		});

		Mud.SetMultiple(new int[] {
			TileID.Mud,
		});

		Sand.PopulateFromSets(TileID.Sets.isDesertBiomeSand);
		Sand.SetMultiple(new int[] {
			TileID.Pearlsand,
			TileID.Ebonsand,
			TileID.Crimsand
		});

		Snow.SetMultiple(new int[] {
			TileID.SnowBlock,
			TileID.SnowCloud,
			//TileID.Cloud,
			//TileID.RainCloud,
			//ItemID.AshBlock,
		});

		Wood.SetMultiple(new int[] {
			TileID.WoodBlock,
			TileID.BorealWood,
			TileID.DynastyWood,
			TileID.LivingWood,
			TileID.PalmWood,
			TileID.SpookyWood,
			TileID.WoodenSpikes,
			TileID.ClosedDoor,
			TileID.OpenDoor,
			TileID.Tables,
			TileID.Tables2,
			TileID.WarTable,
			TileID.Chairs,
			TileID.Bookcases,
			TileID.Dressers,
			TileID.Platforms
		});

		Reverb.SetMultiple(Stone.GetEntries());

		/*TagSystem.SetTagByte(TagGroup.Tile,TileTags.FootstepType,(byte)FootstepType.Gross,new int[] {
			TileID.FleshBlock,TileID.FleshGrass,TileID.FleshIce,TileID.FleshWeeds,TileID.CorruptGrass,
			TileID.CorruptIce,TileID.CorruptThorns,TileID.Mud
		});*/
	}
	void ILoadable.Unload()
	{

	}
}
