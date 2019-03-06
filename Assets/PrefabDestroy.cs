using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestroy : MonoBehaviour
{
    private GameObject unitychan;
    // Start is called before the first frame update
    void Start()
    {
        //Unitychanのゲームオブジェクト取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z - unitychan.transform.position.z < -2)
        {
            Destroy(this.gameObject);
        }

    }
}
