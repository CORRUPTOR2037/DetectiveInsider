using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SpeechTrigger : MonoBehaviour
{
    public AudioSource source;
    public Speech speech;

    void OnTriggerEnter()
    {
        Debug.Log(this);
        SpeechPlayer.Instance.Play(speech, source);
    }
}
