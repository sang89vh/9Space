using Godot;
using System;

public class Level : Node2D
{
    private Player player;
    public override void _Ready()
    {
        player = GetChild<Player>(0);
    }
    
    //remove if out of bounds
    public override void _Process(float delta)
    {
        var children = GetChildren();
        for (var i = 0; i < children.Count; i++)
        {
            var node = (children[i] as Node2D);
            if (node is null)
                continue;
            var position = node.GlobalPosition;
            if (position.x < 0
                || position.x > 720
                || position.y < player.Position.y - 1440
                || position.y > player.Position.y + 1440)
                node.GetParent().RemoveChild(node);
        }
    }
}
