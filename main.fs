module Fs.Main
open Godot

let ready (main: Node3D) =
  let camera = new Camera3D()
  camera.Position <- Vector3(0f, 3f, 52f)
  camera.Current <- true
  camera.RotateX(-0.25f)
  main.AddChild(camera)

  let floor = new MeshInstance3D()
  let planeMesh = new PlaneMesh()
  planeMesh.Size <- Vector2(100f, 100f)
  floor.Mesh <- planeMesh
  main.AddChild(floor)

  let sun = new DirectionalLight3D()
  sun.ShadowEnabled <- true
  sun.Position <- Vector3(0f, 0f, 0f)
  sun.Rotation <- Vector3(-1.0472f, 2.618f, 0f)
  main.AddChild(sun)

  let world = new WorldEnvironment()
  let env = new Environment()
  env.SdfgiEnabled <- true

  world.Environment <- env
  main.AddChild(world)

let run (main: Node3D) delta =
  ()
