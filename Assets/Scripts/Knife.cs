using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public Mesh replace;

    public void Replace()
    {
        GetComponent<PickableItem>().ID = "";
        GetComponent<MeshFilter>().mesh = replace;
    }
}
