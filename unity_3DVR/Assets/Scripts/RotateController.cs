using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class RotateController : MonoBehaviour
{
    [Header("旋轉角度"), Range(-180, 180)]
    public float angle = -130;
    [Header("旋轉速度"), Range(0, 50)]
    public float speed = 1.5f;
    [Header("音效")]
    public AudioClip sound;
    [Header("音量"), Range(0, 5)]
    public float volume = 1;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    public void StartRotate()
    {
        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate()
    {
        aud.PlayOneShot(sound, volume);
        GetComponent<Collider>().enabled = false;

        while (transform.rotation != Quaternion.Euler(0, angle, 0))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, angle, 0), speed * Time.deltaTime);
            yield return null;
        }
    }
}
