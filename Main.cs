using Godot;

public partial class Main : Node3D
{
	public override void _Ready() { Fs.Main.ready(this); }
	public override void _Process(double delta) { Fs.Main.run(this, delta); }
}
