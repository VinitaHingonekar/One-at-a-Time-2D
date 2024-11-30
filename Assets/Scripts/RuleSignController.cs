using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuleSignController : MonoBehaviour
{
    [SerializeField] private GameObject ruleImage;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            ruleImage.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.GetComponent<PlayerController>() != null)
        {
            ruleImage.SetActive(false);
        }
    }
}
