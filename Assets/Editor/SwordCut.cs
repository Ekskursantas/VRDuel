using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody))]
public class SwordCut : MonoBehaviour {

	public Material capMaterial;




    private void OnCollisionEnter(Collision collision)
    {
     

            GameObject victim = collision.collider.gameObject;

            GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
        {
            pieces[1].AddComponent<Rigidbody>();
            MeshCollider mesh = pieces[1].AddComponent<MeshCollider>();
            mesh.convex = true;
        }

            Destroy(pieces[1], 1);
        
    }

}
