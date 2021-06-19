using System;
using Godot;

public class Player : KinematicBody2D, IEntity
{
	public event Action Collision;
	public event Action Death;
	public event Action Attack;
	public short Health { get; set; } = 1;
	public short CooldownBorder => 12;
	public short Cooldown { get; private set; }
	public Vector2 Velocity { get; private set; }
	private const int Speed = 384;

	public override void _Ready()
	{
		Attack += Shoot;
	}

	private void Shoot()
	{
		if (Cooldown <= 0)
		{
			foreach (var vector in Scenes.PlayerAttack)
			{
				var proj = (PlayerProjectile) Scenes.PlayerProjectile.Instance();
				proj.GlobalPosition = GlobalPosition + vector;
				GetParent().AddChild(proj, true);
			}

			Cooldown = CooldownBorder;
		}
	}
	
	public override void _Process(float delta)
	{
		Position += Vector2.Up * 1.5f;
		if (Health < 1) QueueFree();
		Cooldown--;
		GetInput();
	}
	
	public override void _PhysicsProcess(float delta)
	{
		Velocity = MoveAndSlide(Velocity * Speed);
	}
	
	private void GetInput()
	{
		var velocity = new Vector2();
		if (Input.IsActionPressed("player_right") && GlobalPosition.x < 700)
			velocity.x += 1;
		if (Input.IsActionPressed("player_left") && GlobalPosition.x > 20)
			velocity.x -= 1;
		if (Input.IsActionPressed("player_shoot"))
			Attack?.Invoke();
		Velocity = velocity;
	}
}
