using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Src_Background : MonoBehaviour
{
    public GameObject self;
    public GameObject incomeText;

    public void Float_IncomeText()
    {
        Instantiate(incomeText);
    }
}
