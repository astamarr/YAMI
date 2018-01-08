using UnityEngine;
using System.Collections;

public class WinScript : Action
{

    Canvas Win;
    private GameObject Canvas;


    // Use this for initialization
    void Start()
    {

        Canvas = GameObject.FindGameObjectsWithTag("MainCanvas")[0];
        Win = Canvas.transform.FindChild("Win").gameObject.GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Use()
    {
        foreach (GameObject cur in GameObject.FindGameObjectsWithTag("Player"))
        {
            cur.SetActive(false);

        }

        Win.enabled = true;
        Win.GetComponent<Canvas>().enabled = true;
        Cursor.visible = true;

    }

}
