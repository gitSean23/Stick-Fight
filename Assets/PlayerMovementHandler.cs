using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerMovementHandler : MonoBehaviour
{
    private Mover mover;
    // Start is called before the first frame update
    private void Awake()
    {
        mover = GetComponent<Mover>();
    }

    // Update is called once per frame
    public void OnMove(CallbackContext ctx)
    {
          mover.setInputVector(ctx.ReadValue<Vector2>());
    }
}
