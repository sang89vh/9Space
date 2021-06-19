using Godot;
using System;

public class Scout : KinematicBody2D, IEntity
{
    public event Action Collision;
    public event Action Death;
    public event Action Attack;
    public short Health { get; set; } = 4;
    public short CooldownBorder => 0;
    public short Cooldown => 0;
    public Vector2 Velocity { get; private set; } = Vector2.Down * 64;

    public override void _Ready()
    {
        
    }

    public override void _Process(float delta)
    {
        Velocity += Vector2.Down * 8;
        if (Health < 1) QueueFree();
        MoveAndSlide(Velocity);
    }
}