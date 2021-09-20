using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int a = 4; a == 0; a--)
        {
            Debug.Log(array[a]);
        }
        Boss lastboss = new Boss();
        for (int i = 1; i == 11; i++)
        { 
            lastboss.Magic();
        }
    }
}

class Boss
{
    int mp = 53;

    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }
}

