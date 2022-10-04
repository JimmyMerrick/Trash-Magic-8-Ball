using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ShakeIt : MonoBehaviour
{

    public GameObject[] nodes = new GameObject[13];
    
    public GameObject animation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shake8Ball() {

        
        nodes[0].SetActive(false);
        nodes[1].SetActive(false);
        nodes[2].SetActive(false);
        nodes[3].SetActive(false);
        nodes[4].SetActive(false);
        nodes[5].SetActive(false);
        nodes[6].SetActive(false);
        nodes[7].SetActive(false);
        nodes[8].SetActive(false);
        nodes[9].SetActive(false);
        nodes[10].SetActive(false);
        nodes[11].SetActive(false);
        nodes[12].SetActive(false);


        StartCoroutine(Waiter());

        

    }

    IEnumerator Waiter() {
        // Debug.Log("I did it!");

        
        int num = Random.Range(0, 13);

        animation.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        animation.SetActive(false);

        nodes[num].SetActive(true);
    }
}
