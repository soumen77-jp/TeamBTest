using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Angle;
    public float speed = 3.0f;
    Vector3 vec;

    // Start is called before the first frame update
    void Start()
    {
        float rad = Angle * Mathf.Deg2Rad;
        Vector3 direction = new Vector3(Mathf.Cos(rad),Mathf.Sin(rad),  0);
        vec = direction * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += vec;
    }

    //ÉJÉÅÉâÇ…âfÇÁÇ»Ç≠Ç»Ç¡ÇΩÇÁè¡ãé
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
