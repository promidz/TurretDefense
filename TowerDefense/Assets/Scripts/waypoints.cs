using UnityEngine;

public class waypoints : MonoBehaviour {

    public static Transform[] points;

    void Awake()
    {
        //transform.childcount is number of waypoint in waypoints
        points = new Transform[transform.childCount];
        for (int i = 0; i < points.Length; i++)
        {
            //loops through 13 times and assign points[i] = waypoints's child which is waypoint;
            points[i]=transform.GetChild(i);
        }
    }
	
}
