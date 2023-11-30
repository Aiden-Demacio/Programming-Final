using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Vector3 MovDir;
    static bool dir;

    public static Controls _ctrls;
    public static void init(BallController b)
    {
        // Vector3 MovDir;
        _ctrls = new Controls();

        _ctrls.Game.Movement.performed += ctx =>
        {
            b.SetMovDir(ctx.ReadValue<Vector3>());
        };
        _ctrls.Game.DirSwitch.performed += ctx =>
        {
            dir = !dir;
            b.switchDir(dir);
        };
        
    }

    public static void gameMode()
    {
        _ctrls.Game.Enable();
    }





}
