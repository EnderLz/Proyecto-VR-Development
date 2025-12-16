using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    Vector3 ogScale;
    Vector3 incremental = new Vector3(0.001f, 0.001f, 0.001f);
    bool increasing = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ogScale = this.gameObject.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = this.gameObject.transform.localScale;
        if (increasing)
            this.gameObject.transform.localScale = scale + incremental;
        else
            this.gameObject.transform.localScale = scale - incremental;
        
        if (scale.x > ogScale.x * 1.5)
            increasing = false;
        else if (scale.x < ogScale.x / 1.5)
            increasing = true;
    }
}
