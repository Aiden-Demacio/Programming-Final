using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static Vector3 MovDir;


    public static Controls _ctrls;
    public static void init(Player p)
    {
        // Vector3 MovDir;
        _ctrls = new Controls();

        _ctrls.Game.Movement.performed += ctx =>
        {
            p.SetMovDir(ctx.ReadValue<Vector3>());
        };
    }

    public static void gameMode()
    {
        _ctrls.Game.Enable();
    }





}
