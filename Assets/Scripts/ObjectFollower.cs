using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectFollower : MonoBehaviour
{
public GameObject Obj;
 
    Camera mCamera;
    private RectTransform rt;
    Vector2 pos;

    public Transform Object;
     private Text distanceText;
  public bool isImgOn;
     public Image img;
    void Start ()
    {
        mCamera = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
        rt = GetComponent<RectTransform> ();
        distanceText = GetComponentInChildren<Text>();

        distanceText.enabled = true;
         img.enabled = true;
         isImgOn = true;
        
    }
 
    void Update ()
    {
       
      float dist = Vector3.Distance(mCamera.transform.position, Obj.transform.position);
      distanceText.text = dist.ToString("f1") + "m";
       
        if (Obj)
        {
            pos = RectTransformUtility.WorldToScreenPoint (mCamera, Obj.transform.position);
            rt.position = pos;
        }
        else
        {
            Debug.LogError (this.gameObject.name + ": No Object Attached (TrackObject)");
        }
      /*  if(Object.transform.position.z < 0)
        {
             distanceText.enabled = false;
             img.enabled = false;
             isImgOn = false;
        }
        else
        {
             distanceText.enabled = true;
             img.enabled = true;
             isImgOn = true;
        }
         */
 
    }
}
