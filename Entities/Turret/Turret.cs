using Godot;
using System;

public class Turret : KinematicBody2D, IEntity
{
    public event Action Collision;
    public event Action Death;
    public event Action Attack;
    public short Health { get; set; } = 4;
    public short CooldownBorder => 128;
    public short Cooldown { get; private set; }
    public Vector2 Velocity => Vector2.Zero;

    public override void _Ready()
    {
        Attack += Shoot;
    }

    private void Shoot()
    {
        if (Cooldown <= 0)
        {
            foreach (var dir in Scenes.TurretAttack)
            {
                var proj = (EnemyProjectile) Scenes.EnemyProjectile.Instance();
                proj.Position = Position;
                proj.Velocity = dir * 128;
                GetParent().AddChild(proj, true);
            }
            Cooldown = CooldownBorder;
        }
    }
    
    public override void _Process(float delta)
    {
        if (Health < 1) QueueFree();
        Cooldown--;
        Attack();
    }
    
}
