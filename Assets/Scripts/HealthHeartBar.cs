using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHeartBar : MonoBehaviour
{
    public Sprite fullHealth, noHealth;
    Image healthImage;


    private void Awake()
    {
        healthImage = GetComponent<Image>();
    }

    public void SetHeartImage(HeartStatus status)
    {
        switch (status)
        {
            case HeartStatus Empty:
                heartImage
        }
    }
}


public enum HeartStatus
{
    Empty = 0,
    Half = 1,
    Full = 2

}