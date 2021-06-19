using Godot;
using System;

public static class Scenes
{
    //spawn patterns
    public static readonly PackedScene TU_TU = 
        GD.Load<PackedScene>("res://SpawnPatterns/TU_TU.tscn");
    
    public static readonly PackedScene TU_SE = 
        GD.Load<PackedScene>("res://SpawnPatterns/TU_SE.tscn");
    
    public static readonly PackedScene TU_SC = 
        GD.Load<PackedScene>("res://SpawnPatterns/TU_SC.tscn");
    
    public static readonly PackedScene TU_FI = 
        GD.Load<PackedScene>("res://SpawnPatterns/TU_FI.tscn");
    
    public static readonly PackedScene TU_DR = 
        GD.Load<PackedScene>("res://SpawnPatterns/TU_DR.tscn");
    
    public static readonly PackedScene SE_SE = 
        GD.Load<PackedScene>("res://SpawnPatterns/SE_SE.tscn");
    
    public static readonly PackedScene SE_SC = 
        GD.Load<PackedScene>("res://SpawnPatterns/SE_SC.tscn");
    
    public static readonly PackedScene SE_FI = 
        GD.Load<PackedScene>("res://SpawnPatterns/SE_FI.tscn");
    
    public static readonly PackedScene SE_DR = 
        GD.Load<PackedScene>("res://SpawnPatterns/SE_DR.tscn");
    
    public static readonly PackedScene SC_SC = 
        GD.Load<PackedScene>("res://SpawnPatterns/SC_SC.tscn");
    
    public static readonly PackedScene SC_FI = 
        GD.Load<PackedScene>("res://SpawnPatterns/SC_FI.tscn");
    
    public static readonly PackedScene SC_DR = 
        GD.Load<PackedScene>("res://SpawnPatterns/SC_DR.tscn");
    
    public static readonly PackedScene FI_FI = 
        GD.Load<PackedScene>("res://SpawnPatterns/FI_FI.tscn");
    
    public static readonly PackedScene FI_DR = 
        GD.Load<PackedScene>("res://SpawnPatterns/FI_DR.tscn");
    
    public static readonly PackedScene DR_DR = 
        GD.Load<PackedScene>("res://SpawnPatterns/DR_DR.tscn");

    //main
    public static PackedScene Player =
        GD.Load<PackedScene>("res://Entities/Player/Player.tscn");
    
    public static readonly PackedScene PlayerProjectile =
        GD.Load<PackedScene>("res://Entities/Projectile/PlayerProjectile/PlayerProjectile.tscn");
    
    public static readonly PackedScene EnemyProjectile =
        GD.Load<PackedScene>("res://Entities/Projectile/EnemyProjectile/EnemyProjectile.tscn");
    
    /*public static readonly PackedScene Camera =
        GD.Load<PackedScene>()*/
    
    //attack patterns
    public static readonly Vector2[] TurretAttack = 
    {
        new Vector2(-1,1),
        new Vector2(1,1)
    };
    
    public static readonly Vector2[] SentryAttack = 
    {
        Vector2.Left,
        Vector2.Right
    };
    
    public static readonly Vector2[] FighterAttack = 
    {
        new Vector2(-1,1),
        new Vector2(0,1),
        new Vector2(1,1)
    };

    public static readonly Vector2[] PlayerAttack =
    {
        new Vector2(-24, 16),
        new Vector2(0, -16),
        new Vector2(24, 16)
    };
}
