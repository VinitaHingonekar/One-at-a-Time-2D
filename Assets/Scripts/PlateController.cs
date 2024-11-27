using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateController : MonoBehaviour
{
    public WallController wall;
    public Animator animator;

    // public bool isPlayerOnPlate;

    public enum PlateNumber {ONE, TWO}
    public PlateNumber plateNumber;
    public WallController WallController;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null || other.gameObject.GetComponent<BoxController>() != null)
        {
            animator.SetBool("isPressed", true);
            if(plateNumber == PlateNumber.ONE)
                WallController.platePressed1 = true;
            else if(plateNumber == PlateNumber.TWO)
                WallController.platePressed2 = true;

            Debug.Log("1 " + WallController.platePressed1);
            Debug.Log("2 " + WallController.platePressed2);

            wall.Open();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null  || other.gameObject.GetComponent<BoxController>() != null)
        {
            animator.SetBool("isPressed", false);
            if(plateNumber == PlateNumber.ONE)
                WallController.platePressed1 = false;
            else if(plateNumber == PlateNumber.TWO)   
                WallController.platePressed2 = false;

            Debug.Log("1 " + WallController.platePressed1);
            Debug.Log("2 " + WallController.platePressed2);
            
            if(!WallController.platePressed1 && !WallController.platePressed2)
            {
                wall.Close();
            }
        }
    }
}
