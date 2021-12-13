using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Src_Game : MonoBehaviour
{
    public Text stageVal, moneyVal;
    public Text contextA, contextE, contextB;
    public GameObject background;
    public GameObject[] stageImg = new GameObject[4];
    int stage, money;
    int ability, employee, building;
    int countA, countE, countB;
    float time;

    void Awake()
    {
        stageImg[0].SetActive(true);
        stageImg[1].SetActive(false);
        stageImg[2].SetActive(false);
        stageImg[3].SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        stage = 1;
        money = 100;
        time = 0;
        ability = employee = building = 0;
        countA = countE = countB = 0;
        stageVal.text = stage.ToString();
        moneyVal.text = money.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 5)
        {
            time = 0;
            Press_Clicker();
        }
    }

    void Update_Text()
    {
        stageVal.text = stage.ToString();
        moneyVal.text = money.ToString();
        contextA.text = "Income : +10 per Buy\nCost : -" + (100 * (countA + 1)).ToString() + " per Buy";
        contextE.text = "Income : +50 per Buy\nCost : -" + (500 * (countE + 1)).ToString() + " per Buy";
        contextB.text = "Income : +2000 per Buy\nCost : -" + (20000 * (countB + 1)).ToString() + " per Buy";
    }

    public void Press_Clicker()
    {
        background.GetComponent<Src_Background>().Float_IncomeText();
        money += ability + employee + building;
        Update_Text();
    }

    public void Press_Cheat()
    {
        money += 500000;
        Update_Text();
    }

    public void Press_Ability()
    {
        if (money >= 100 * (countA + 1))
        {
            countA++;
            money -= 100 * countA;
            ability += 10;
            Update_Text();
        }
    }

    public void Press_Employee()
    {
        if (money >= 500 * (countE + 1))
        {
            countE++;
            money -= 500 * countE;
            employee += 50;
            Update_Text();
        }
    }

    public void Press_Building()
    {
        if (money >= 20000 * (countB + 1))
        {
            countB++;
            money -= 20000 * countB;
            building += 2000;
            Update_Text();

            stage = countB / 3;
            if (stage > 7) stage = 7;
            switch (stage)
            {
                case 0:
                    stageImg[0].SetActive(true);
                    break;
                case 1:
                    stageImg[0].SetActive(false);
                    stageImg[1].SetActive(true);
                    break;
                case 2:
                    stageImg[1].SetActive(false);
                    stageImg[2].SetActive(true);
                    break;
                case 3:
                    stageImg[2].SetActive(false);
                    stageImg[3].SetActive(true);
                    break;
                default:
                    break;
            }
        }
    }

    public int Get_Income()
    {
        return ability + employee + building;
    }
}
