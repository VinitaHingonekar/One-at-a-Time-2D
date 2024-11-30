using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerSwitcher playerSwitcher;
    // public float smoothSpeed = 0.125f;
    public Vector3 offset; 

    private Transform currentTarget;

    // Update is called once per frame
    void LateUpdate()
    {
        UpdateCurrentTarget();

        if (currentTarget != null)
        {
            Vector3 desiredPosition = currentTarget.position + offset;
            // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            // transform.position = desiredPosition;

            transform.position = new Vector3(desiredPosition.x, 0, -10f);
        }
    }

    private void UpdateCurrentTarget()
    {
        foreach (var character in playerSwitcher.characters)
        {
            PlayerController controller = character.GetComponent<PlayerController>();
            if (controller != null && controller.isActive)
            {
                currentTarget = character.transform;
                return;
            }
        }
    }
}
