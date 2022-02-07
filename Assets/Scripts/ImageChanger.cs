using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    [SerializeField] private Image imageComponent;
    // Start is called before the first frame update
    void Start()
    {
        Sprite sprite = Resources.Load<Sprite>("Chat");
        imageComponent.sprite = sprite;
    }

    
}
