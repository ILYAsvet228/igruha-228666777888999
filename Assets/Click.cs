using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{

    Text text;
    int count = 0;

    // Start is called before the first frame update
    private void Start()
    {
        text = gameObject.GetComponent<Text>();
        text.text = "�� ���������� 0 ���� ������";
        text.color = ColorChanche(count);
    }

    public void OnClickPlus()
    {
        count += 1000;
        text.text =  "�� ���������� " + Formate(count) + " ���� ������";
        text.color = ColorChanche(count);
    }

    public void OnClickMinus()
    {
        count -= 1000;
        text.text = "�� ���������� " + Formate(count) + " ���� ������";
        text.color = ColorChanche(count);
    }
    // Update is called once per frame

    private Color ColorChanche(int x)
    {
        Color color = Color.white;
        if (x > 0) color = Color.green;
        if (x < 0) color = Color.red;
        return color;
    }

    private string Formate(int count)
    {
        if (count > 999)
            return count / 1000 + "�";
        return count.ToString();
    }
}


