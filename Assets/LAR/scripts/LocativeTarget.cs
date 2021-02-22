/*
 * Mário Vairinhos 2020 
 * DECA LAR - LOCATIVE AUGMENTED REALITY
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocativeTarget : MonoBehaviour
{
    public NasaAPI GetAPI;
    [Header("Google Maps Coordinates")]
    public double latitude;
    public double longitude;
    public double altitude;

    [Header("Enable")]
    public float MaximumDistance=1000;

    private double  raioTerra = 6372797.560856f;

    private void Start()
    {
        //print(raioTerra + " " + longitude);
        latitude = GetAPI.lats;
        longitude = GetAPI.longs;
        altitude = GetAPI.alts;
    }


    private void Update()
    {
        Vector3 coord = calculaPosCoordCam();
        transform.position = coord;
        //print(coord.x +" " + coord.y + " " + coord.z);
         latitude = GetAPI.lats;
        longitude = GetAPI.longs;
        altitude = GetAPI.alts;

    }

    private Vector3 calculaPosCoordCam()
    {
         latitude = GetAPI.lats;
        longitude = GetAPI.longs;
        altitude = GetAPI.alts;
        // a dif de long varia consoante e lat
        // isto só dá assim com distâncias pequenas
        //Vector3 p = new Vector3();

        double dlat = latitude - LocativeGPS.Instance.latitude;
            dlat = getCoordEmMetrosDeRaio(raioTerra, dlat);

        double dlon = longitude - LocativeGPS.Instance.longitude;

            double raioLat = Mathf.Cos((float)latitude) * raioTerra;
            dlon = getCoordEmMetrosDeRaio(raioLat, dlon);


        double dalt = altitude - LocativeGPS.Instance.altitude; 
        return new Vector3((float)dlat, (float)dalt, (float)dlon);
    }



    private double getCoordEmMetrosDeRaio(double raio, double angulo)
    {
        double metros = (raio / 180) * Mathf.PI;// quantos metros tem um grau para aquele lat
        metros *= angulo;
        return metros;
    }


}
