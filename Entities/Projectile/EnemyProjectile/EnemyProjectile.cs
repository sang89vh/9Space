using System;
using Godot;

public class EnemyProjectile : KinematicBody2D, IEntity
{
    public event Action Collision;
    public event Action Death;
    public event Action Attack;
    public short Health { get; set; }
    public short CooldownBorder { get; }
    public short Cooldown { get; }
    public Vector2 Velocity { get; set; }
    
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