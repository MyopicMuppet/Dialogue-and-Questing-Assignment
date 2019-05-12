using UnityEngine;
using System.Collections;
//this script can be found in the Component section under the option Intro RPG/Player/Interact
[AddComponentMenu("Intro /PRG/RPG/Player/Interact")]
public class Interact : MonoBehaviour
{
    #region Variables
    public GameObject questGiverCanvas;
    public GameObject ringBearerCanvas;


    #endregion
    #region Start
    //connect our player to the player variable via tag
    //connect our Camera to the mainCam variable via tag
    #endregion
    #region Update
    private void Update()
    {


        //if our interact key is pressed
        if (Input.GetButtonDown("Interact"))
        {
            //create a ray
            Ray Interact;

            //this ray is shooting out from the main cameras screen point center of screen
            Interact = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create hit info
            RaycastHit hitInfo;
            //if this physics raycast hits something within 10 units
            if (Physics.Raycast(Interact, out hitInfo, 10))
            {


                #region NPC tag
                //and that hits info is tagged NPC

                if (hitInfo.collider.CompareTag("QuestGiver"))
                {

                    questGiverCanvas.SetActive(true);
                    //Dialogue dlg = hitInfo.transform.GetComponent<Dialogue>();
                    if (questGiverCanvas != null)
                    {
                        //dlg.showDlg = true;
                        Movement.canMove = false;
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                    }


                    //Debug that we hit a NPC
                    Debug.Log("QuestGiver");
                }


                if (hitInfo.collider.CompareTag("RingBearer"))
                {
                    ringBearerCanvas.SetActive(true);
                    //Dialogue dlg = hitInfo.transform.GetComponent<Dialogue>();
                    if (ringBearerCanvas != null)
                    {
                        //dlg.showDlg = true;
                        Movement.canMove = false;
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                    }


                    //Debug that we hit a NPC
                    Debug.Log("QuestGiver");
                }






                #endregion
                #region Item
                //and that hits info is tagged Item
                /* if (hitInfo.collider.CompareTag("Item"))
                 {

                     //Debug that we hit an Item
                     Debug.Log("item");
                 }*/





                #endregion
            }
        }
    }

    public void EndDialogue()
    {
        //index = 0;
        //showDlg = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Movement.canMove = true;
    }

    #endregion
}






