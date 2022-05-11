using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float velocity;
    private MeshRenderer Background;

    // Start is called before the first frame update
    void Start()
    {
        Background = this.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Background.material.mainTextureOffset = new Vector3(Time.deltaTime * velocity * 1f, 0, 0);
    }
}
