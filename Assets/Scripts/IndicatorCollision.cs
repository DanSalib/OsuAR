using UnityEngine;
using System.Collections;

public class IndicatorCollision : MonoBehaviour
{
    public bool isHit = false;

    public void OnPointerEnter()
    {
        this.isHit = true;
    }  

    public void OnPointerExit()
    {
        this.isHit = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        this.isHit = true;
    }

    private void OnTriggerExit(Collider other)
    {
        this.isHit = false;
    }
}