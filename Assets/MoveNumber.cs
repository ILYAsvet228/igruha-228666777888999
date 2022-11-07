using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveNumber : MonoBehaviour
{
    private IEnumerator coroutine;
    [SerializeField]
    float speed = 5;
    [SerializeField]
    Vector2 vector2;
    // Start is called before the first frame update
    void Start()
    {
        vector2 = new Vector2(Random.Range(-3f, 3f), Random.Range(0f, 3f));
        coroutine = WaitAndPrint(0.02f);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Translate(vector2 * Time.deltaTime / speed);
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        float i = 225;
        while (i > 0)
        {
            i -= 3;
            this.gameObject.GetComponent<Text>().color = new Color(0, 0, 0, i / 225);
            yield return new WaitForSeconds(waitTime);
            print("ќжидание  " + waitTime.time);
        }
        Destroy(gameObject);
    }
}
