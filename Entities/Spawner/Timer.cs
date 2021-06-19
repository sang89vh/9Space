using Godot;
using System;

public class Timer : Godot.Timer
{
    public override void _Ready() => this.Start();
}
