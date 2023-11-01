using Godot;

public partial class Main : Node3D
{
	public override void _Ready() { Fs.Main.ready(); }
	public override void _Process(double delta) { Fs.Main.run(delta); }
}
