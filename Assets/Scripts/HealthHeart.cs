using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHeart : MonoBehaviour
{
    public Sprite Fullheart, emptyHeart;
    Image heartImage;

    private void Awake()
    {
       heartImage = GetComponent<Image>();
    }
}

public enum HeartStatus
{
    Empty = 0,

}
