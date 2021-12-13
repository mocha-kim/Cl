using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Animation_Floating : MonoBehaviour
{
    public Text self;
    GameObject parent;
    GameObject gameLogic;

    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.Find("GameLogic");
        self.text = "+" + gameLogic.GetComponent<Src_Game>().Get_Income().ToString();
        parent = GameObject.Find("Background");
        self.transform.SetParent(parent.transform);
        self.transform.localPosition = new Vector3(-160, -300, 0);
        self.transform.DOMoveY(200, 2).OnComplete(()=>
        {
            Destroy(self.gameObject);
        });
        self.DOFade(0, 2);
    }
}
