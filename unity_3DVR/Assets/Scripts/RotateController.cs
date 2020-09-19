using UnityEngine;
using System.Collections;

public class RotateController : MonoBehaviour
{
    [Header("旋轉角度"), Range(0, 180)]
    public float rotare = 90;
    [Header("旋轉速度"), Range(0, 50)]
    public float speed = 1.5f;

    void StartRotate()
    {
        
    }

}
