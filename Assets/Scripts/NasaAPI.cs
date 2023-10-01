using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using Newtonsoft.Json;
using System;
public class NasaAPI : MonoBehaviour
{
    private string jsonURL = "https://api.n2yo.com/rest/v1/satellite/positions/25544/40.475/-80.142/0/2/&apiKey=xxxxxxx";
     public Text StationName;
    public Text Longitude;
    public Text Latitude;
    public Text Altitude;

    public Text Error;

    public double longs;
     public double lats;
     public double alts;

    public void GetCoordinates()
    {
       
        StartCoroutine(getData());

    }
    IEnumerator getData()
    {
        

using (UnityWebRequest webRequest = UnityWebRequest.Get(jsonURL))
            {
                yield return webRequest.SendWebRequest();

                if (webRequest.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.Log(webRequest.error);
                }

                else
                {
                     Root Json = JsonUtility.FromJson<Root>(webRequest.downloadHandler.text) ;
                    try
                    {
                         //Info myDeserializedClass = JsonConvert.DeserializeObject<Info>(output); 
                 //Root Json = JsonUtility.FromJson<Root>(webRequest.downloadHandler.text) ;
                //Lat.text = Json.satname;
                StationName.text = "INTERNATIONAL " + Json.info.satname;
                Longitude.text = "Long: " + Json.positions[0].satlongitude.ToString();
                Latitude.text = "Lat: " + Json.positions[0].satlatitude.ToString();
                Altitude.text = "Alt: " + Json.positions[0].sataltitude.ToString();
                longs = Json.positions[0].satlongitude;
                lats = Json.positions[0].satlatitude;
                alts = Json.positions[0].sataltitude;
                       
                    }
                    catch
                    {
                         Error.text = Json.positions[0].error.ToString();
                    }
               
               
                }
               
            }
           yield return new WaitForSeconds(0.5f);
           StartCoroutine(getData());
    }

   
    

  /*  private string url = "https://api.n2yo.com/rest/v1/satellite/positions/25544/40.475/-80.142/0/2/&apiKey=xxxxxxxx";
    public Text StationName;
    public Text Longitude;
    public Text Latitude;
    public void GetCoordinates()
    {
       StartCoroutine(getData());
    }
    IEnumerator getData()
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();
        if(request.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(request.error);
        }
        else
        {
            Root APINasa = JsonConvert.DeserializeObject<Root>(request.downloadHandler.text);
            Position APINasa2 = JsonConvert.DeserializeObject<Position>(request.downloadHandler.text);
            StationName.text = "INTERNATIONAL " + APINasa.info.satname;
            Longitude.text = APINasa2.satlatitude.ToString();
            Latitude.text = APINasa2.satlongitude.ToString();

        }
    }
    */
    
}
    

