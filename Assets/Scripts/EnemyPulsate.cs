using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPulsate : MonoBehaviour
{
    public float pulseSpeed = 2f;
    public float pulseAmount = 0.2f;
    private Vector3 baseScale;

    // Start is called before the first frame update
    void Start()
    {
        baseScale = transform.localScale;    
    }

    // Update is called once per frame
    void Update()
    {
        float scale = 1 + Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;
        transform.localScale = baseScale * scale;
    }
}
