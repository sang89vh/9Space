using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public class Spawner : Node2D
{
    private Queue<PackedScene> SpawnPatterns = new Queue<PackedScene>();

    public override void _Ready()
    {
        SpawnPatterns.Enqueue(Scenes.TU_TU);
        SpawnPatterns.Enqueue(Scenes.TU_SE);
        SpawnPatterns.Enqueue(Scenes.TU_SC);
        SpawnPatterns.Enqueue(Scenes.TU_FI);
        SpawnPatterns.Enqueue(Scenes.TU_DR);
        
        SpawnPatterns.Enqueue(Scenes.SE_SE);
        SpawnPatterns.Enqueue(Scenes.SE_SC);
        SpawnPatterns.Enqueue(Scenes.SE_FI);
        SpawnPatterns.Enqueue(Scenes.SE_DR);
        
        SpawnPatterns.Enqueue(Scenes.SC_SC);
        SpawnPatterns.Enqueue(Scenes.SC_FI);
        SpawnPatterns.Enqueue(Scenes.SC_DR);
        
        SpawnPatterns.Enqueue(Scenes.FI_FI);
        SpawnPatterns.Enqueue(Scenes.FI_DR);
        
        SpawnPatterns.Enqueue(Scenes.DR_DR);
    }

    public override void _Process(float delta)
    {
        Position += Vector2.Up * 1.5f;
    }

    public void OnTimeout()
    {
        if (!SpawnPatterns.Any()) return;
        var scene = SpawnPatterns.Dequeue();
        var pattern = (Node2D) scene.Instance();
        pattern.Position = Position;
        GetParent().AddChild(pattern, true);
    }
}
