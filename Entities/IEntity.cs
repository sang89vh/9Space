using System;
using Godot;

public interface IEntity
{
    public event Action Collision;
    public event Action Death;
    public event Action Attack;
    public short Health { get; set; }
    public short CooldownBorder { get; }
    public short Cooldown { get; }
    public Vector2 Velocity { get; }
}