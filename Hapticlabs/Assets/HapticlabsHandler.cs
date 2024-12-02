using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class HapticlabsHandler : MonoBehaviour
{
    int i = 1;
    float amplitude = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Hapticlabs.SetAmplitudeScale(amplitude);
            float intensity = Random.Range(1, 10);
            //float scale = Random.Range(1f, 5);
            //Hapticlabs.SetAmplitudeScale(scale);
            Hapticlabs.StartTrack("Drill Vibration",true); //Drill Simulation
           // Hapticlabs.StartTrack("Drill Simulation", false, 1); //Drill Simulation
            i++;
            amplitude += 0.1f;


            //StartCoroutine(ScaleIntensity());

            //if (i < 10)
            //{   /// do instantiation noise here
            //    Hapticlabs.SetAmplitudeScale(amplitude);
            //    Hapticlabs.StartTrack("Drill Simulation", true, amplitude); //Drill Simulation
            //    Debug.Log(i);

            //}
            //else
            //{
            //    {
            //        Hapticlabs.StartTrack("Drill Simulation", true, amplitude); //Drill Simulation
            //    }
            //}
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Hapticlabs.StartTrack("Test_1", false, 1f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Hapticlabs.StartTrack("Test_1", true, 2f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Hapticlabs.StartTrack("Test_1", false, 3f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Hapticlabs.StartTrack("Test_1", false, 4f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Hapticlabs.StartTrack("Test_1", false, 5f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Hapticlabs.StartTrack("Test_1", false, 6f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            Hapticlabs.StartTrack("Test_1", false, 7f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            Hapticlabs.StartTrack("Test_1", false, 8f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Hapticlabs.StartTrack("Test_1", false, 9f);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            Hapticlabs.StartTrack("Test_1", false, 10f);
        }
    }

    IEnumerator ScaleIntensity()
    {
        int i = 1;
        float amplitude = 0.1f;
        while (true)
        {

            if (i < 10)
            {   /// do instantiation noise here
                i++;
                amplitude += 0.1f;
                Hapticlabs.SetAmplitudeScale(amplitude);
                Hapticlabs.StartTrack("Drill Vibration", true, amplitude); //Drill Simulation
                Debug.Log(i);
                yield return new WaitForSeconds(1f);

            }


        }
    }

    public void DynamicVibration(Transform movableObj, Transform staticObj)
    {
        float distance = Vector3.Distance(movableObj.position, staticObj.position);
         Debug.Log("distance: " + distance);
        if(distance < 0.1f)
        {
            Hapticlabs.StartTrack("Test_1", false, 1f);
        }
        else if(distance < 0.2)
        {
            Hapticlabs.StartTrack("Test_1", false, 2f);
        }
        else if (distance < 0.3)
        {
            Hapticlabs.StartTrack("Test_1", false, 3f);
        }
        else if (distance < 0.4)
        {
            Hapticlabs.StartTrack("Test_1", false, 4f);
        }
        else if (distance < 0.5)
        {
            Hapticlabs.StartTrack("Test_1", false, 7f);
        }
        else if (distance < 0.65)
        {
            Hapticlabs.StartTrack("Test_1", false, 8f);
        }
        else if (distance >= 0.65)
        {
            Hapticlabs.StartTrack("Test_1", false, 10f);
        }
    }

    private void OnDisable()
    {
        Debug.Log("Stoppp: ");
        Hapticlabs.Stop();
    }
}