using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    public GameObject fx;
    bool CanAttack;
    void Start()
    {
        anim = GetComponent<Animator>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(SwordAttack());
        }
    }

    IEnumerator SwordAttack()
    {
        anim.SetTrigger("SwordAttack");
        yield return new WaitForSeconds(0.5f);
        fx.GetComponent<Sword>().Play();
        yield return new WaitForSeconds(0.8f);
        fx.GetComponent<Sword>().Stop();
    }
}
