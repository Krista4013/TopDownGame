
using UnityEngine;



public class NpcManager : MonoBehaviour
    {

    [SerializeField]
    private GameObject Npc1Talk;
    [SerializeField]
    private GameObject Talk1;



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Talk1.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Talk1.SetActive(false);
            Npc1Talk.SetActive(false);
        }
    }


    public void OpenTalk()
    {
        Npc1Talk.SetActive(true);
    }
}

