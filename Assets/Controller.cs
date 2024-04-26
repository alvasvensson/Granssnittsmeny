using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> smycken;
    [SerializeField]
    public List<GameObject> pickFrames;

    int currentSelection = -1;


    public void SetSelected(int selection)
    {
        for (int i = 0; i < pickFrames.Count; i++)
        {
            if (i != selection)
            {
                pickFrames[i].SetActive(false);
                smycken[i].SetActive(false);
            }
            else
            {
                pickFrames[i].SetActive(true);
                smycken[i].SetActive(true);
            }
            currentSelection = selection;
        }
    }



    void Start()
    {
        foreach (GameObject p in pickFrames) { p.SetActive(false); }
        foreach (GameObject s in smycken) { s.SetActive(false); }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
