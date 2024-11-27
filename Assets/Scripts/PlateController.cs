using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateController : MonoBehaviour
{
    public Animator animator;

    public enum PlateNumber {ONE, TWO}
    public PlateNumber plateNumber;
    public WallController wallController;

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
                wallController.platePressed1 = true;
            else if(plateNumber == PlateNumber.TWO)
                wallController.platePressed2 = true;

            Debug.Log("1 " + wallController.platePressed1);
            Debug.Log("2 " + wallController.platePressed2);

            wallController.Open();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null  || other.gameObject.GetComponent<BoxController>() != null)
        {
            animator.SetBool("isPressed", false);
            if(plateNumber == PlateNumber.ONE)
                wallController.platePressed1 = false;
            else if(plateNumber == PlateNumber.TWO)   
                wallController.platePressed2 = false;

            // Debug.Log("1 " + wallController.platePressed1);
            // Debug.Log("2 " + wallController.platePressed2);
            
            if(!wallController.platePressed1 && !wallController.platePressed2)
            {
                wallController.Close();
            }
        }
    }
}
