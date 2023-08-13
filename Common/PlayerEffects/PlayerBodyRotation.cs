using System;
using Microsoft.Xna.Framework;
using OverhaulMovement.Core.Configuration;
using Terraria;
using Terraria.ModLoader;
using OverhaulMovement.Utilities;

namespace OverhaulMovement.Common.PlayerEffects;

public sealed class PlayerBodyRotation : ModPlayer
{
	public float Rotation;
	public float RotationOffsetScale;

	public override void PreUpdate()
	{
		if (Player.dead) {
			return;
		}

		Player.fullRotationOrigin = new Vector2(11, 22);
	}

	public override void PostUpdate()
	{
		if (Player.sleeping.isSleeping) {
			return;
		}

		if (RotationOffsetScale != 0f && ClientConfig.Instance.EnablePlayerRotation) {
			float movementRotation;

			if (Player.OnGround()) {
				movementRotation = Player.velocity.X * (Player.velocity.X < Main.MouseWorld.X ? 1f : -1f) * 0.025f;
			} else {
				movementRotation = MathHelper.Clamp(Player.velocity.Y * Math.Sign(Player.velocity.X) * -0.015f, -0.4f, 0.4f);
			}

			if (Player.mount.Active) {
				movementRotation *= 0.5f;
			}

			Rotation += movementRotation;

			//TODO: If swimming, multiply by 4.
		}

		/*
		while (rotation >= MathHelper.TwoPi) {
			rotation -= MathHelper.TwoPi;
		}
		
		while (rotation <= -MathHelper.TwoPi) {
			rotation += MathHelper.TwoPi;
		}
		*/

		Player.fullRotation = Rotation * Player.gravDir;

		Rotation = 0f;
		RotationOffsetScale = 1f;
	}
}
