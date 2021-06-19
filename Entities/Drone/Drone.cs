using Godot;
using System;

public class Drone : KinematicBody2D, IEntity
{
    public event Action Collision;
    public event Action Death;
    public event Action Attack;
    public short Health { get; set; } = 4;
    public short CooldownBorder => 32;
    public short Cooldown { get; private set; }
    public int HorAccel { get; private set; } = 16; 

    
    public Vector2 Velocity { get; private set; } = new Vector2(256, 128);

    public override void _Process(float delta)
    {
        Move();
        Velocity = new Vector2(Velocity.x + HorAccel, Velocity.y);
        if (Health < 1) QueueFree();
        MoveAndSlide(Velocity);
    }

    public void Move()
    {
        if (Cooldown == 0)
        {
            HorAccel = -HorAccel;
            Cooldown = CooldownBorder;
        }
        Cooldown--;
    }
}