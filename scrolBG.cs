using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolBG : MonoBehaviour
{
    public float bgspeed;
    public Renderer bgRend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(bgspeed * Time.deltaTime, 0f);
    }
}
