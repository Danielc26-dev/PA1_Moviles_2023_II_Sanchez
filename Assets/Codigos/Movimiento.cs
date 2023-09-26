using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public ObjectPool objectPool;
    public Transform spawnPoint;
    public Transform desaparicionPoint;
    public float velocidad = 1.0f;
    public float tiempoEntreSpawn = 2.0f; 

    private void Start()
    {

        InvokeRepeating("GenerarObjetoDesdePool", 0f, tiempoEntreSpawn);
    }

    void GenerarObjetoDesdePool()
    {
        GameObject obj = objectPool.GetObjectFromPool();

        if (obj != null)
        {
            obj.transform.position = spawnPoint.position;
            obj.SetActive(true);

            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.left * velocidad;
            }

            foreach (Transform child in transform)
            {
                if (child.gameObject.activeInHierarchy)
                {
                    child.Translate(Vector3.forward * velocidad * Time.deltaTime);

                    if (child.position.x > -50f)
                    {
                        Debug.Log("Pase por aqui");
                        child.gameObject.SetActive(false);
                    }
                }

                
            }
        }
    }
}
