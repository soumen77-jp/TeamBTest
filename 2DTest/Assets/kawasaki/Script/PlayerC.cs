using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    public float speed = 3.0f;
    int direction = 0;
    float axisH;
    float axisV;
    public float angleZ = 90.0f;
    Rigidbody2D rbody;
    bool isMoving = false;

    //p1からp2の角度を返す
    float GetAngle(Vector2 p1, Vector2 p2)
    {
        float angle;
        if(axisH!=0||axisH!=0)
        {


            float dx = p2.x - p1.x;
            float dy = p2.y - p1.y;

            float rad = Mathf.Atan2(dy, dx);

            angle = rad * Mathf.Rad2Deg;

        }
        else
        {
            //停止中であれば以前の角度を維持
            angle = angleZ;

        }
        return angle;

    }



    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving ==false)
        {
            axisH = Input.GetAxisRaw("Horizontal");
            axisV = Input.GetAxisRaw("Vertical");

        }
        //キー入力から移動角度を求める
        Vector2 fromPt = transform.position;
        Vector2 toPt = new Vector2(fromPt.x + axisH, fromPt.y + axisV);
        angleZ = GetAngle(fromPt, toPt);
        //移動方向から向いてる方向とアニメーション更新

    }
}
