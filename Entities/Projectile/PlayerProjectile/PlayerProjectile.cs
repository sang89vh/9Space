using Godot;
using System;

public class PlayerProjectile : KinematicBody2D, IEntity
{
	public event Action Collision;
	public event Action Death;
	public event Action Attack;
	public short Health { get; set; }
	public short CooldownBorder { get; }
	public short Cooldown { get; }
	public Vector2 Velocity { get; private set; }

	public override void _Ready()
	{
		Velocity = Vector2.Up * 768;
	}

	public override void _Process(float delta)
	{
		Velocity = MoveAndSlide(Velocity);
	}
	
	public void OnOverlap(Node body)
	{
		((IEntity) body).Health--;
		QueueFree();
	}
}
