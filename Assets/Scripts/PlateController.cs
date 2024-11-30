using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateController : MonoBehaviour
{
    public Animator animator;

    public enum PlateNumber {ONE, TWO}
    public PlateNumber plateNumber;
    public WallController wallController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null || other.gameObject.GetComponent<BoxController>() != null)
        {
            SoundManager.Instance.Play(Sounds.PressurePlate);
            animator.SetBool("isPressed", true);
            if(plateNumber == PlateNumber.ONE)
                wallController.platePressed1 = true;
            else if(plateNumber == PlateNumber.TWO)
                wallController.platePressed2 = true;

            wallController.Open();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null  || other.gameObject.GetComponent<BoxController>() != null)
        {
            SoundManager.Instance.Play(Sounds.PressurePlate);
            animator.SetBool("isPressed", false);
            if(plateNumber == PlateNumber.ONE)
                wallController.platePressed1 = false;
            else if(plateNumber == PlateNumber.TWO)   
                wallController.platePressed2 = false;

            if(!wallController.platePressed1 && !wallController.platePressed2)
            {
                wallController.Close();
            }
        }
    }
}
