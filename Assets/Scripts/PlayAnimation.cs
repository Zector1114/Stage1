using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    private Animator animator;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (animator != null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                switch (count)
                {
                    case 0:
                        animator.SetTrigger("menuTr");
                        break;
                    case 1:
                        animator.SetTrigger("introTr");
                        break;
                    case 2:
                        animator.SetTrigger("forgetTr");
                        break;
                    case 3:
                        animator.SetTrigger("sitTr");
                        break;
                    case 4:
                        animator.SetTrigger("lookTr");
                        break;
                    case 5:
                        animator.SetTrigger("sipTr");
                        break;
                    case 6:
                        animator.SetTrigger("shakeTr");
                        break;
                    case 7:
                        animator.SetTrigger("chaseTr");
                        break;
                    case 8:
                        animator.SetTrigger("shakeTr");
                        break;
                    case 9:
                        animator.SetTrigger("catchTr");
                        break;
                    default:
                        break;
                }

                count++;
            }
        }
    }
}
